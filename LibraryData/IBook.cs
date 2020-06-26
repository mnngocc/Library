using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface IBook
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        public bool Add(Book newBook);
        public bool Update(Book book);
        string GetAuthorOrDirector(int id);
        public LibraryBranch GetCurrentLocation(int id);
        string GetDeweyIndex(int id);
        string GetTitle(int id);
        string GetIsbn(int id);
        int GetNumBook();
    
    }
}
