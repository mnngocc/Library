using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface IVideo
    {
        IEnumerable<Video> GetAll();
        Video GetById(int id);
        void Add(Video newVideo);
        public bool Update(Video video);
        string GetAuthorOrDirector(int id);
        string GetTitle(int id);
        int NumVideo();
    }
}
