using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public interface IUser
    {
        IEnumerable<User> GetAll();
        User Get(string username);
        bool CheckLogin(string username, string password);
        void Add(User newUser);
        
    }
}
