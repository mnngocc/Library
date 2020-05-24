using Castle.MicroKernel.Registration.Proxy;
using Library.Data;
using Library.Data.Models;
using LibraryData;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class LibraryBranchService : ILibraryBranchService
    {
        private readonly LibraryDbContext _context;

        public LibraryBranchService(LibraryDbContext context)
        {
            _context = context;
        }

        public void Add(LibraryBranch newBranch)
        {
          
            _context.Add(newBranch);
            _context.SaveChanges();
        }
      

        public LibraryBranch Get(int branchId)
        {
            return _context.LibraryBranches
                .Include(b => b.Patrons)
                .Include(b => b.LibraryAssets)
                .FirstOrDefault(p => p.Id == branchId);
        }

        public IEnumerable<LibraryBranch> GetAll()
        {
            return _context.LibraryBranches.Include(a => a.Patrons).Include(a => a.LibraryAssets);
        }

        public int GetAssetCount(int branchId)
        {
            return Get(branchId).LibraryAssets.Count();
        }

        public IEnumerable<LibraryAsset> GetAssets(int branchId)
        {
            return _context.LibraryBranches.Include(a => a.LibraryAssets)
                .First(b => b.Id == branchId).LibraryAssets;
        }

        public decimal GetAssetsValue(int branchId)
        {
            var assetsValue = GetAssets(branchId).Select(a => a.Cost);
            return assetsValue.Sum();
        }
        public Dictionary<string, int> GetAssetsTitle(int branchId)
        {
            //IList listAsssets = null;           
            Dictionary<string, int> listAssets = new Dictionary<string, int>();
            var assetsItem = GetAssets(branchId);
            foreach (var item in assetsItem)
            {
                var Title = item.Title;
                var Id = item.Id;
                //var Asset = $"{Title} {Id}";
                listAssets.Add(Title, Id);
            }    
            return listAssets;
        }

        public IEnumerable<string> GetBranchHours(int branchId)
        {        
                var hours = _context.BranchHours.Where(a => a.Branch.Id == branchId);

                var displayHours =
                    DataHelpers.HumanizeBusinessHours(hours);
                return displayHours; 
        }

        public LibraryBranch GetById(int id)
        {
            return GetAll().FirstOrDefault(b => b.Id == id);
            //throw new NotImplementedException();
        }

        public int GetPatronCount(int branchId)
        {
            return Get(branchId).Patrons.Count();
        }

        public IEnumerable<Patron> GetPatrons(int branchId)
        {
            return _context.LibraryBranches.Include(a => a.Patrons).First(b => b.Id == branchId).Patrons;
        }

        //TODO: Implement 
        public bool IsBranchOpen(int branchId)
        {
            return true;
        }
        public void Remove(int id)
        {
            var _branch = _context.LibraryBranches.Find(id);
            _context.LibraryBranches.Remove(_branch);
            _context.SaveChanges();
        }

        public bool Update(LibraryBranch branch)
        {
            var _branch = _context.LibraryBranches.Find(branch.Id);
            try
            {
                _branch.Name = branch.Name;
                _branch.Address = branch.Address;
                _branch.Telephone = branch.Telephone;
                _branch.Description = branch.Description;
                _branch.OpenDate = branch.OpenDate;
                //Update Author or Director

                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        IEnumerable<LibraryBranch> ILibraryBranchService.ToList()
        {
            return _context.LibraryBranches.ToList();
        }
    }
}


