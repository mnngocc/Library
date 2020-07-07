using Library.Data.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ILibraryBranchService
    {
        IEnumerable<LibraryBranch> ToList();
        IEnumerable<LibraryBranch> GetAll();
        IEnumerable<Patron> GetPatrons(int branchId);
        IEnumerable<LibraryAsset> GetAssets(int branchId);
        LibraryBranch GetById(int id);
        LibraryBranch Get(int branchId);
        void Add(LibraryBranch newBranch);
        IEnumerable<string> GetBranchHours(int branchId);
        bool IsBranchOpen(int branchId);
        int GetAssetCount(int branchId);
        int TotalAssets();
        int TotalPatrons();
        Dictionary<string, int> GetAssetsTitle(int branchId);

        int GetPatronCount(int branchId);
        decimal GetAssetsValue(int id);
        void Remove(int id);
        bool Update(LibraryBranch branch);
    }
}
