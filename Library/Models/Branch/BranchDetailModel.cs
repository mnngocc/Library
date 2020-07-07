using Library.Data.Models;
using Library.Models.Catalog;
using System.Collections.Generic;

namespace Library.Models.Branch
{
    public class BranchDetailModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string BranchName { get; set; }
        public string BranchOpenedDate { get; set; }
        public string Telephone { get; set; }
        public bool IsOpen { get; set; }
        public string Description { get; set; }
        public int NumberOfPatrons { get; set; }
        public int NumberOfAssets { get; set; }
        public decimal TotalAssetValue { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<string> HoursOpen { get; set; }
        public string AssetsTitle { get; set; }
        public int TotalAssets { get; set; }
    }
}