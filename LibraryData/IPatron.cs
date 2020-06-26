using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface IPatron
    {
        IEnumerable<Patron> GetAll();
        IEnumerable<Patron> GetAllPatrons();
        Patron Get(int id);
        Patron GetByUsername(string username);
        void Add(Patron newPatron);
        int AddNewPatron(Patron newPatron);
        int AddNewLibraryCard(LibraryCard libCard);
        bool UpdateLibCard(LibraryCard libCard);
        bool Authorize(string username, string password);
        bool AuthorizeEmployee(string username, string password);
        bool AuthorizeAdmin(string username, string password);
        bool CheckUserExist(string username, string email);
        bool CheckCurrentPass(int id,string current);
        int NumPatron();
        public bool Update(Patron newPatron);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId);
        IEnumerable<Hold> GetHolds(int patronId);
        IEnumerable<Checkout> GetCheckouts(int id);

        IEnumerable<Checkout> GetCheckoutsByUsername(string username);
        IEnumerable<Hold> GetHoldsByUsername(string username);
        IEnumerable<CheckoutHistory> GetCheckoutsHistoryByUsername(string username);
    }
}
