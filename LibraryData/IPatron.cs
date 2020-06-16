﻿using Library.Data.Models;
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
        bool Authorize(string username, string password);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId);
        IEnumerable<Hold> GetHolds(int patronId);
        IEnumerable<Checkout> GetCheckouts(int id);

        IEnumerable<Checkout> GetCheckoutsByUsername(string username);
        IEnumerable<Hold> GetHoldsByUsername(string username);
        IEnumerable<CheckoutHistory> GetCheckoutsHistoryByUsername(string username);
    }
}
