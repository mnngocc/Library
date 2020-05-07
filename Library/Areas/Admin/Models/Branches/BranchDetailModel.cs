using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Areas.Admin.Models.Statuses
{
    public class BranchDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; set; }
        public string imageURL { get; set; }


    }
}
