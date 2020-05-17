﻿using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface IPatron
    {
        IEnumerable<Patron> GetAll();
        Patron Get(int id);
        void Add(Patron newPatron);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId);
        IEnumerable<Hold> GetHolds(int patronId);
        IEnumerable<Checkout> GetCheckouts(int id);
    }
}
