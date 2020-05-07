using System;
using System.Collections.Generic;
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

        public void CheckInItem(int id, int libraryCardId)
        {
            throw new NotImplementedException();
        }

        public void CheckoutItem(int id, int libraryCardId)
        {
            throw new NotImplementedException();
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

        public string GetCurrentHoldPlaced(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        IEnumerable<Hold> ICheckout.GetCurrentHold(int id)
        {

            return _context.Holds
                .Include(h => h.LibraryAsset)
                .Where(h => h.LibraryAsset.Id == id);
        }
    }
}
