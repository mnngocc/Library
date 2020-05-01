using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Areas.Admin.Models.Statuses
{
    public class StatusIndexModel
    {
        public IEnumerable<StatusIndexListingModel> Statuses { get; set; }
    }
}
