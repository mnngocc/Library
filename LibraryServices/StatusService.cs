using Library.Data;
using Library.Data.Models;
using LibraryData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryServices
{
    public class StatusService : IStatus
    {
        private LibraryDbContext _context;

        public IEnumerable<Status> GetStatuses => _context.Statuses;

        public StatusService()
        {
        }
        public IEnumerable<Status> GetAll()
        {
            //throw new NotImplementedException();
            return _context.Statuses;

        }
        public StatusService(LibraryDbContext context)
        {
            _context = context;
        }

        public Status Get_Status(int? id)
        {
            return _context.Statuses.Find(id);
        }
    }
}
