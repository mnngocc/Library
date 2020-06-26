using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.Home
{
    public class HomeDetailModel
    {
        public int NumBook { get; set; }
        public int NumVideo { get; set; }
        public int NumPatron { get; set; }
        public int TotalCheckout { get; set; }
        public int NumBranch { get; set; }
        public int TopAsset { get; set; }
        public string TopAssetName { get; set; }
        public string TopAssetImg { get; set; }
        public string PatronName { get; set; }
        public DateTime MemberSince { get; set; }
        public string TopBranchName { get; set; }
        public string TopBranhImg { get; set; }

    }
}
