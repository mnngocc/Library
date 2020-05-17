using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Areas.Admin.Models.Assets
{
    public class VideoIndexListingModel
    {

        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string AuthorOrDirector { get; set; }
        public string NumberOfCopies { get; set; }
        public string Year { get; set; }
        public string Status { get; set; }
        public string Cost { get; set; }
        public string Location { get; set; }
    }
}
