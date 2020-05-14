using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Library.Data;
using Library.Data.Models;
using LibraryData;
using Microsoft.EntityFrameworkCore;

namespace LibraryServices
{
    public class CheckoutService : ICheckout
    {
        private LibraryDbContext _context;

        public CheckoutService(LibraryDbContext context)
        {
            _context = context;
        }
        public void Add(Checkout newCheckout)
        {
            _context.Add(newCheckout);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }
        private void CheckoutToEarliestHold(int assetId, IEnumerable<Hold> currentHolds)
        {
            var earliestHold = currentHolds.OrderBy(a => a.HoldPlaced).FirstOrDefault();
            if (earliestHold == null) return;
            var card = earliestHold.LibraryCard;
            _context.Remove(earliestHold);
            _context.SaveChanges();

            CheckoutItem(assetId, card.Id);
        }

        public void CheckInItem(int id)
        {
            var now = DateTime.Now;

            var item = _context.LibraryAssets
                .First(a => a.Id == id);

            _context.Update(item);

            // remove any existing checkouts on the item
            var checkout = _context.Checkouts
                .Include(c => c.LibraryAsset)
                .Include(c => c.LibraryCard)
                .FirstOrDefault(a => a.LibraryAsset.Id == id);
            if (checkout != null) _context.Remove(checkout);

            // close any existing checkout history
            var history = _context.CheckoutHistories
                .Include(h => h.LibraryAsset)
                .Include(h => h.LibraryCard)
                .FirstOrDefault(h =>
                    h.LibraryAsset.Id == id
                    && h.CheckedIn == null);
            if (history != null)
            {
                _context.Update(history);
                history.CheckedIn = now;
            }

            // look for current holds
            var currentHolds = _context.Holds
                .Include(a => a.LibraryAsset)
                .Include(a => a.LibraryCard)
                .Where(a => a.LibraryAsset.Id == id);

            // if there are current holds, check out the item to the earliest
            if (currentHolds.Any())
            {
                CheckoutToEarliestHold(id, currentHolds);
                return;
            }

            // otherwise, set item status to available
            item.Status = _context.Statuses.FirstOrDefault(a => a.Name == "Available");

            _context.SaveChanges();
        }
        private DateTime GetDefaultCheckoutTime(DateTime now)
        {
            return now.AddDays(30);
        }

        public void CheckoutItem(int id, int libraryCardId)
        {
            if (IsCheckedOut(id)) return;

            var item = _context.LibraryAssets
                .Include(a => a.Status)
                .First(a => a.Id == id);

            _context.Update(item);

            item.Status = _context.Statuses
                .FirstOrDefault(a => a.Name == "Checked Out");

            var now = DateTime.Now;

            var libraryCard = _context.LibraryCards
                .Include(c => c.Checkouts)
                .FirstOrDefault(a => a.Id == libraryCardId);

            var checkout = new Checkout
            {
                LibraryAsset = item,
                LibraryCard = libraryCard,
                Since = now,
                Until = GetDefaultCheckoutTime(now)
            };

            _context.Add(checkout);

            var checkoutHistory = new CheckoutHistory
            {
                CheckedOut = now,
                LibraryAsset = item,
                LibraryCard = libraryCard
            };

            _context.Add(checkoutHistory);
            _context.SaveChanges();
        }


        public IEnumerable<Checkout> GetAll()
        {
            return _context.Checkouts;
            //throw new NotImplementedException();
        }

        public Checkout GetbyId(int CheckoutId)
        {
            return GetAll().FirstOrDefault(checkout => checkout.Id == CheckoutId);
           // throw new NotImplementedException();
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int id)
        {
            return _context.CheckoutHistories
                    .Include(h => h.LibraryAsset)
                    .Include(h => h.LibraryCard)
                    .Where(h => h.LibraryAsset.Id == id);
           // throw new NotImplementedException();
        }
      

        public string GetCurrentHoldPatronName(int id)
        {

            throw new NotImplementedException();
        }
        public string GetCurrentHoldPatron(int id)
        {
            var hold = _context.Holds
                .Include(a => a.LibraryAsset)
                .Include(a => a.LibraryCard)
                .Where(v => v.Id == id);

            var cardId = hold
                .Include(a => a.LibraryCard)
                .Select(a => a.LibraryCard.Id)
                .FirstOrDefault();

            var patron = _context.Patrons
                .Include(p => p.LibraryCard)
                .First(p => p.LibraryCard.Id == cardId);

            return patron.FirstName + " " + patron.LastName;
        }

        public string GetCurrentHoldPlaced(int id)
        {
            var hold = _context.Holds
                .Include(a => a.LibraryAsset)
                .Include(a => a.LibraryCard)
                .Where(v => v.Id == id);

            return hold.Select(a => a.HoldPlaced)
                .FirstOrDefault().ToString(CultureInfo.InvariantCulture);
        }

        public string GetCurrentPatron(int id)
        {
            var checkout = _context.Checkouts
                 .Include(a => a.LibraryAsset)
                 .Include(a => a.LibraryCard)
                 .FirstOrDefault(a => a.LibraryAsset.Id == id);

            if (checkout == null) return "Not checked out.";

            var cardId = checkout.LibraryCard.Id;

            var patron = _context.Patrons
                .Include(p => p.LibraryCard)
                .First(c => c.LibraryCard.Id == cardId);

            return patron.FirstName + " " + patron.LastName;
        }

        public Checkout GetLatestCheckout(int assetId)
        {
            return _context.Checkouts
                .Where(c => c.LibraryAsset.Id == assetId)
                .OrderByDescending(c => c.Since)
                .FirstOrDefault();
           // throw new NotImplementedException();
        }

        public void MarkFound(int id)
        {
            var now = DateTime.Now;
            var item = _context.LibraryAssets.FirstOrDefault(a => a.Id == id);
            _context.Update(item);
            item.Status = _context.Statuses.FirstOrDefault(stt => stt.Name == "Available");

            //Remove  các checkout 
            var checkout = _context.Checkouts
                            .FirstOrDefault(co => co.LibraryAsset.Id == id);
            if (checkout != null)
            {
                _context.Remove(checkout);
            }

            //Remove lich su checkout
            var history = _context.CheckoutHistories.FirstOrDefault(h => h.LibraryAsset.Id == id 
                                                                && h.CheckedIn == null);
                if (history != null)
            {
                _context.Update(history);
                history.CheckedIn = now;
            }

            _context.SaveChanges();

        }

        public void MarkLost(int id)
        {
            var item = _context.LibraryAssets.FirstOrDefault(a => a.Id == id);
            _context.Update(item);
            item.Status = _context.Statuses.FirstOrDefault(stt => stt.Name == "Lost");
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void PlaceHold(int assetId, int libraryCardId)
        {
            var asset = _context.LibraryAssets
                .Include(a => a.Status)
                .First(a => a.Id == assetId);
            var card = _context.LibraryCards
                .First(a => a.Id == libraryCardId);
            _context.Update(asset);
            if (asset.Status.Name == "Available")
                asset.Status = _context.Statuses.FirstOrDefault(a => a.Name == "On Hold");
            var now = DateTime.Now;
            var hold = new Hold
            {
                HoldPlaced = now,
                LibraryAsset = asset,
                LibraryCard = card
            };

            _context.Add(hold);
            _context.SaveChanges();
        }

 
        public bool IsCheckedOut(int id)
        {
            var isCheckedOut = _context.Checkouts.Any(a => a.LibraryAsset.Id == id);

            return isCheckedOut;
        }

        IEnumerable<Hold> ICheckout.GetCurrentHold(int id)
        {
            return _context.Holds
               .Include(h => h.LibraryAsset)
               .Where(h => h.LibraryAsset.Id == id);
        }
    }
}
