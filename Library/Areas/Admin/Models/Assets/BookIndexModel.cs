using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Areas.Admin.Models.Assets
{
    public class BookIndexModel
    {
        public IEnumerable<BookIndexListingModel> Books { get; set; }
    }
}
