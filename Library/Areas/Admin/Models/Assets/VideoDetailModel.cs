using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Areas.Admin.Models.Assets
{
    public class VideoDetailModel
    {
        public int AssetId { get; set; }
        public string AuthorOrDirector { get; set; }
        public string Title { get; set; }
        public int NumberOfCopies { get; set; }
        public int Year { get; set; }
        public string Status { get; set; }
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
    }

}
