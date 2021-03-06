﻿using System;
using System.Collections.Generic;
using Library.Data.Models;

namespace Library.Models.Patron
{
    public class PatronDetailModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? LibraryCardId { get; set; }
        public string Address { get; set; }
        public DateTime? MemberSince { get; set; }
        public string Telephone { get; set; }
        //public string TelephoneNumber { get; set; }
        public string HomeLibrary { get; set; }
        public int HomeLibraryBranchId { get; set; }
        public decimal? OverdueFees { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IEnumerable<Role> Role { get; set; }
        public IEnumerable<Checkout> AssetsCheckedOut { get; set; }
        public IEnumerable<CheckoutHistory> CheckoutHistory { get; set; }
        public IEnumerable<Hold> Holds { get; set; }
    }
}