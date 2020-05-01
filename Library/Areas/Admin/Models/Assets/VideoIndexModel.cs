using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Areas.Admin.Models.Assets
{
    public class VideoIndexModel
    {
        public IEnumerable<VideoIndexListingModel> Videos { get; set; }
    }
}
