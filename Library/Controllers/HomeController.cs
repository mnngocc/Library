using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Library.Areas.Admin.Models;
using LibraryData;
using Library.Areas.Admin.Models.Branches;
using Library.Models;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILibraryBranchService _branch;

    
        public HomeController(ILogger<HomeController> logger, ILibraryBranchService branchService)
        {
            _logger = logger;
            _branch = branchService;
        }

        public IActionResult Index()
        {
            var totalAssets = _branch.TotalAssets();
            var branch = _branch.GetAll();
            var List = branch
                       .Select(result => new BranchDetailModel
                       {
                           Id = result.Id,
                           ImageURL = result.ImageUrl,
                           Name = result.Name,
                           Address = result.Address,
                           Telephone = result.Telephone,
                           Description = result.Description,
                           OpenDate = result.OpenDate
                       });
            var model_branch = new BranchIndexModel()
            {
                Branches = List,
                TotalAssets = totalAssets,
                TotalPatron = _branch.TotalPatrons()
            };
            return View(model_branch);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
