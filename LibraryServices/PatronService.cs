using Library.Data;
using Library.Data.Models;
using LibraryData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class PatronService : IPatron
    {
        private readonly LibraryDbContext _context;

        public PatronService(LibraryDbContext context)
        {
            _context = context;
        }
        public void Add(Patron newPatron)
        {
            _context.Add(newPatron);
            _context.SaveChanges();
        }

        public bool Authorize(string username, string password)
        {
            //throw new NotImplementedException();
            var details = _context.Patrons.Where(p => p.Username == username && p.Password == password).FirstOrDefault();
            if (details != null) return true;
            else return false;
        }

        public Patron Get(int id)
        {
            return _context.Patrons
                .Include(a => a.LibraryCard)
                .Include(a => a.HomeLibraryBranch)
                .FirstOrDefault(p => p.Id == id);
        }
        public Patron GetByUsername(string username)
        {
            return _context.Patrons
               .Include(a => a.LibraryCard)
               .Include(a => a.HomeLibraryBranch)
               .FirstOrDefault(p => p.Username == username);
        }

        public IEnumerable<Patron> GetAll()
        {
            return _context.Patrons
               .Include(a => a.LibraryCard)
               .Include(a => a.HomeLibraryBranch);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId)
        {
            var cardId = _context.Patrons
                .Include(a => a.LibraryCard)
                .FirstOrDefault(a => a.Id == patronId)?
                .LibraryCard.Id;

            return _context.CheckoutHistories
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(a => a.LibraryCard.Id == cardId)
                .OrderByDescending(a => a.CheckedOut);
        }

        public IEnumerable<Checkout> GetCheckouts(int id)
        {
            var patronCardId = Get(id).LibraryCard.Id;
            return _context.Checkouts
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(v => v.LibraryCard.Id == patronCardId);
        }

        public IEnumerable<Checkout> GetCheckoutsByUsername(string username)
        {
            var patronCardId = GetByUsername(username).LibraryCard.Id;
            return _context.Checkouts
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(v => v.LibraryCard.Id == patronCardId);
        }

        public IEnumerable<Hold> GetHolds(int patronId)
        {
            var cardId = _context.Patrons
               .Include(a => a.LibraryCard)
               .FirstOrDefault(a => a.Id == patronId)?
               .LibraryCard.Id;

            return _context.Holds
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(a => a.LibraryCard.Id == cardId)
                .OrderByDescending(a => a.HoldPlaced);
        }

        public IEnumerable<Hold> GetHoldsByUsername(string username)
        {
            var cardId = _context.Patrons
               .Include(a => a.LibraryCard)
               .FirstOrDefault(a => a.Username == username)?
               .LibraryCard.Id;

            return _context.Holds
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(a => a.LibraryCard.Id == cardId)
                .OrderByDescending(a => a.HoldPlaced);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutsHistoryByUsername(string username)
        {
            var cardId = _context.Patrons
                .Include(a => a.LibraryCard)
                .FirstOrDefault(a => a.Username == username)?
                .LibraryCard.Id;

            return _context.CheckoutHistories
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(a => a.LibraryCard.Id == cardId)
                .OrderByDescending(a => a.CheckedOut);
        }
    }
}
