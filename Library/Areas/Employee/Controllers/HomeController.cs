using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Library.Models;
using LibraryData;
using Library.Models.Catalog;
using Library.Data.Models;
using Microsoft.AspNetCore.Http;

namespace Library.Areas.Employee.Controllers
{
    [Area("Employee")]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ILibraryAsset _assets;
        private ICheckout _checkouts;
        private readonly IPatron _patronService;
        public HomeController(ILibraryAsset assets, ICheckout checkouts, ILogger<HomeController> logger, IPatron patron)
        {
            _assets = assets;
            _checkouts = checkouts;
            _logger = logger;
            _patronService = patron;
        }


        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return View("Login");
            }    
            else
            {
                var assetModels = _assets.GetAll();
                var ListingResult = assetModels
                            .Select(result => new AssetIndexListingModel
                            {
                                Id = result.Id,
                                ImageURL = result.ImageUrl,
                                AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                                DeweyCallNumber = _assets.GetDeweyIndex(result.Id),
                                Title = result.Title,
                                Type = _assets.GetType(result.Id)
                            });
                var model = new AssetIndexModel()
                {
                    Assets = ListingResult
                };
                return View(model);
            }    
            
        }

       
        public IActionResult Login(Patron patron)
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitLogin(Patron patron)
        {
            bool result = _patronService.AuthorizeEmployee(patron.Username, patron.Password);
            var patron_id = _patronService.GetByUsername(patron.Username);

            if (result)
            {

                HttpContext.Session.SetString("username", patron.Username);
                HttpContext.Session.SetInt32("id", patron_id.Id);
                HttpContext.Session.SetInt32("LibraryCard", patron_id.LibraryCard.Id);
                
                var assetModels = _assets.GetAll();
                var ListingResult = assetModels
                            .Select(result => new AssetIndexListingModel
                            {
                                Id = result.Id,
                                ImageURL = result.ImageUrl,
                                AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                                DeweyCallNumber = _assets.GetDeweyIndex(result.Id),
                                Title = result.Title,
                                Type = _assets.GetType(result.Id)
                            });
                var model = new AssetIndexModel()
                {
                    Assets = ListingResult
                };
                return View("Index",model);
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");
            }
            //return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return View("Login");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
