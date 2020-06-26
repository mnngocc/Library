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
    public class VideoService : IVideo

    {
        private LibraryDbContext _context;
        public VideoService()
        {

        }
        public VideoService(LibraryDbContext context)
        {
            _context = context;
        }
        public void Add(Video newVideo)
        {
            _context.Add(newVideo);
            _context.SaveChanges();
        }

        public IEnumerable<Video> GetAll()
        {
            return _context.Videos.Include(asset => asset.Status);
        }

        public string GetAuthorOrDirector(int id)
        {
            return
               GetAll().FirstOrDefault(asset => asset.Id == id).Director;
        }

        public Video GetById(int id)
        {
            return GetAll().FirstOrDefault(asset => asset.Id == id);
        }

        public string GetTitle(int id)
        {
            return _context.Videos.FirstOrDefault(a => a.Id == id).Title;
        }

        public int NumVideo()
        {
            return _context.Videos.Count();
        }

        public bool Update(Video video)
        {
            var _asset = _context.Videos.Find(video.Id);
            try
            {
                _asset.Title = video.Title;
                _asset.Year = video.Year;
                _asset.Cost = video.Cost;
                _asset.NumberOfCopies = video.NumberOfCopies;
                _asset.Director = video.Director;

                //Update Author or Director
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    }

