using Library.Data;
using Library.Data.Models;
using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryServices
{
    public class UserService : IUser
    {
        private readonly LibraryDbContext _context;

        public UserService(LibraryDbContext context)
        {
            _context = context;
        }

        public void Add(User newUser)
        {
            throw new NotImplementedException();
        }

        public bool CheckLogin(string username, string password)
        {
            throw new NotImplementedException();
            //var 
        }

        public User Get(string username)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
