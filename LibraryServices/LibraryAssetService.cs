using Library.Data;
using Library.Data.Models;
using LibraryData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAsset
    {
        private LibraryDbContext _context;

        public LibraryAssetService()
        {
       
        }
        public LibraryAssetService(LibraryDbContext context)
        {
            _context = context;
        }
        public void Add(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges();
        
            //throw new NotImplementedException();
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets
                                    .Include(asset => asset.Status)
                                    .Include(asset => asset.Location);
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = _context.LibraryAssets.OfType<Book>()
                            .Where(asset => asset.Id == id).Any();
            var isVideo = _context.LibraryAssets.OfType<Video>()
                            .Where(asset => asset.Id == id).Any();
            return isBook ?
                _context.Books.FirstOrDefault(book => book.Id == id).Author :
                _context.Videos.FirstOrDefault(video => video.Id == id).Director
                ?? "Unknown";
            
        }
        public string GetType(int id)
        {
            var book = _context.LibraryAssets
                  .OfType<Book>().SingleOrDefault(a => a.Id == id);
            return book != null ? "Book" : "Video";
        }
       
        public LibraryAsset GetById(int id)
        {
            return GetAll().FirstOrDefault(asset => asset.Id == id);
            // throw new NotImplementedException();
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            return GetById(id).Location;
            // return _context.LibraryAssets.FirstOrDefault(asset => asset.Id == id).Location;
            // throw new NotImplementedException();
        }

        public string GetDeweyIndex(int id)
        {
            if (_context.Books.Any(book => book.Id == id))
            {
                return _context.Books.FirstOrDefault(book => book.Id == id).DeweyIndex;
            }
       
            else return "";
            //throw new NotImplementedException();
        }

        public string GetIsbn(int id)
        {
            if (_context.Books.Any(a => a.Id == id))
            {
                return _context.Books.FirstOrDefault(a => a.Id == id).ISBN;
            }
            else
                return "";
            //throw new NotImplementedException();
        }

        public LibraryCard GetLibraryCardByAssetId(int id)
        {
            return _context.LibraryCards
                .FirstOrDefault(c => c.Checkouts
                    .Select(a => a.LibraryAsset)
                    .Select(v => v.Id).Contains(id));
        }

        public string GetTitle(int id)
        {
            
                return _context.Books.FirstOrDefault(a => a.Id == id).Title;
           
            //throw new NotImplementedException();
        }

        public bool Update(LibraryAsset asset)
        {
            var _asset = _context.LibraryAssets.Find(asset.Id);
                try
            {     
                    _asset.Title = asset.Title;
                    _asset.Year = asset.Year;
                    _asset.Cost = asset.Cost;
                    _asset.NumberOfCopies = asset.NumberOfCopies;                 
                //Update Author or Director
                             
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Remove(int id)
        {
            var _asset = _context.LibraryAssets.Find(id);
            _context.LibraryAssets.Remove(_asset);
            _context.SaveChanges();
        }

        public void SetTitle(string title, int id)
        {
            var item = _context.LibraryAssets.FirstOrDefault(a => a.Id == id);
            _context.Update(item);
            item.Title = title;
           // throw new NotImplementedException();
        }

        public LibraryAsset Get(int id)
        {
            return _context.LibraryAssets
               .Include(a => a.Status)
               .Include(a => a.Location)
               .FirstOrDefault(a => a.Id == id);
        }

        //Book or Video?

    }
}
