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
            var now = DateTime.Now;
            var data = _context.Checkouts
                .Include(a => a.LibraryCard)
                .Include(a => a.LibraryAsset)
                .Where(v => v.LibraryCard.Id == patronCardId);
             
                return data;
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

        public IEnumerable<Patron> GetAllPatrons()
        {
            return _context.Patrons
               .Include(a => a.LibraryCard)
               .Include(a => a.HomeLibraryBranch)
               .Include(a => a.Role)
               .Where(a => a.Role.RoleID == 3);
        }

        public bool CheckUserExist(string username, string email)
        {
            //throw new NotImplementedException();
            var data = _context.Patrons
                .Where(p => p.Username == username).FirstOrDefault();
            var mail = _context.Patrons
                .Where(p => p.Email == email).FirstOrDefault();
            if (data != null || mail != null) return true;
            return false;
        }

        public int AddNewPatron(Patron newPatron)
        {           
            _context.Patrons.Add(newPatron);
            _context.SaveChanges();
            int idInsertedPatron = newPatron.Id;
            return idInsertedPatron;
        }

        public int AddNewLibraryCard(LibraryCard libCard)
        {           
            _context.LibraryCards.Add(libCard);
            _context.SaveChanges();
            int idInserted = libCard.Id;
            return idInserted;
        }

        public bool AuthorizeEmployee(string username, string password)
        {
            //throw new NotImplementedException();
            var details = _context.Patrons.Where(p => p.Username == username && p.Password == password && p.RoleID == 2).FirstOrDefault();
            if (details != null) return true;
            else return false;
        }

        public bool AuthorizeAdmin(string username, string password)
        {
            //throw new NotImplementedException();
            var details = _context.Patrons.Where(p => p.Username == username && p.Password == password && p.RoleID == 1).FirstOrDefault();
            if (details != null) return true;
            else return false;
        }

        public bool Update(Patron newPatron)
        {
            var _patron = _context.Patrons.Find(newPatron.Id);
            try
            {
                _patron.FirstName = newPatron.FirstName;
                _patron.LastName = newPatron.LastName;
                _patron.Address = newPatron.Address;
                _patron.Email = newPatron.Email;
                _patron.TelephoneNumber = newPatron.TelephoneNumber;
                _patron.DateOfBirth = newPatron.DateOfBirth;
                //Update Author or Director

                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckCurrentPass(int id,string current)
        {
            var data = _context.Patrons
               .Where(p => p.Id == id && p.Password == current).FirstOrDefault();
           
            if (data != null) return true;
            return false;
        }

        public bool UpdateLibCard(LibraryCard libCard)
        {
            var _libCard = _context.LibraryCards.Find(libCard.Id);
            try
            {
                _libCard.Fees = libCard.Fees;
                //Update Author or Director
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int NumPatron()
        {
            return _context.Patrons.Count();
            //throw new NotImplementedException();
        }
    }
}
