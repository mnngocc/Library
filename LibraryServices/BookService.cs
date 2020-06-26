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
    public class BookService : IBook
    {
        private LibraryDbContext _context;
        public BookService()
        {

        }
        public BookService(LibraryDbContext context)
        {
            _context = context;
        }
        public bool  Add(Book newBook)
        {

            try
            {
                _context.Books.Add(newBook);
                _context.SaveChanges();
               
                return true;
            }
            catch
            {
                //throw new ArgumentOutOfRangeException(nameof(newBook), "lỗi");
             
                return false;
            }
           

        }

  

        public IEnumerable<Book> GetAll()
        {
            //throw new NotImplementedException();
            return _context.Books.Include(asset => asset.Status);
           
        }

        public string GetAuthorOrDirector(int id)
        {
            return
                GetAll().FirstOrDefault(asset => asset.Id == id).Author;
            //  throw new NotImplementedException();
        }
        public Book GetById(int id)
        {
            return GetAll().FirstOrDefault(asset => asset.Id == id);
            //throw new NotImplementedException();
        }

        public string GetDeweyIndex(int id)
        {
            //throw new NotImplementedException();
            if (_context.Books.Any(book => book.Id == id))
            {
                return _context.Books.FirstOrDefault(book => book.Id == id).DeweyIndex;
            }
            else return "";
        }

        public string GetIsbn(int id)
        {
            if (_context.Books.Any(a => a.Id == id))
            {
                return _context.Books.FirstOrDefault(a => a.Id == id).ISBN;
            }
            else
                return "";
        }
        public LibraryBranch GetCurrentLocation(int id)
        {
            return GetById(id).Location;
        }

        public string GetTitle(int id)
        {
            return _context.Books.FirstOrDefault(a => a.Id == id).Title;
        }

        public bool Update(Book book)
        {
            var _asset = _context.Books.Find(book.Id);
            try
            {
                _asset.Title = book.Title;
                _asset.Year = book.Year;
                _asset.Cost = book.Cost;
                _asset.NumberOfCopies = book.NumberOfCopies;
                _asset.Author = book.Author;
                _asset.DeweyIndex = book.DeweyIndex;
                //Update Author or Director
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetNumBook()
        {
            return _context.Books.Count();

        }
    }
}
