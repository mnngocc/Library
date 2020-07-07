using Library.Data;
using Library.Data.Models;
using Library.Models.Home;
using LibraryData;
using LibraryServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Library.Areas.admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller

    {
        private readonly IPatron _patronService;
        private readonly IBook _book;
        private readonly IVideo _video;
        private readonly ICheckout _checkout;
        public HomeController(IPatron patron, IBook book, IVideo video, ICheckout checkout)
        {
            _patronService = patron;
            _book = book;
            _video = video;
            _checkout = checkout;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return View("Login");
            }
            else if (HttpContext.Session.GetInt32("role_id") == 1)
            {
                 var numBook_ = _book.GetNumBook();
                string msg = "";
                var numVideo = _video.NumVideo();
                var numPatron = _patronService.NumPatron();
                var numCheckout = _checkout.NumCheckout();
                var numBranch = _checkout.NumBranch();
                var list = _checkout.TopAsset();
                msg += list.ToString();
                var topAssetName = _checkout.TopAssetName();
                var patronDetail = _checkout.TopPatron();
                var branch = _checkout.TopBranch();
                var model = new HomeDetailModel
                {
                    NumBook = numBook_,
                    NumVideo = numVideo,
                    NumPatron = numPatron,
                    TotalCheckout = numCheckout,
                    NumBranch = numBranch,
                    TopAssetName = topAssetName,
                    TopAssetImg = _checkout.TopAssetImg(),
                    PatronName = patronDetail.FirstName + " " + patronDetail.LastName,
                    MemberSince = patronDetail.LibraryCard.Created,
                    TopBranchName = branch.Name,
                    TopBranhImg = branch.ImageUrl
                };
                return View(model);
                //return Content(msg);
            }    
                
            else
                return View("Login");
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitLogin(Patron patron)
        {
            bool result = _patronService.AuthorizeAdmin(patron.Username, patron.Password);
            var patron_id = _patronService.GetByUsername(patron.Username);

            if (result)
            {
                HttpContext.Session.SetString("username", patron.Username);
                HttpContext.Session.SetInt32("id", patron_id.Id);
                HttpContext.Session.SetInt32("LibraryCard", patron_id.LibraryCard.Id);
                HttpContext.Session.SetInt32("role_id", patron_id.RoleID);
                var numBook_ = _book.GetNumBook();
                var numVideo = _video.NumVideo();
                var numPatron = _patronService.NumPatron();
                var numCheckout = _checkout.NumCheckout();
                var numBranch = _checkout.NumBranch();
                var topAssetName = _checkout.TopAssetName();
                var patronDetail = _checkout.TopPatron();
                var branch = _checkout.TopBranch();
                var model = new HomeDetailModel
                {
                    NumBook = numBook_,
                    NumVideo = numVideo,
                    NumPatron = numPatron,
                    TotalCheckout = numCheckout,
                    NumBranch = numBranch,
                    TopAssetName = topAssetName,
                    TopAssetImg = _checkout.TopAssetImg(),
                    PatronName = patronDetail.FirstName + " " + patronDetail.LastName,
                    MemberSince = patronDetail.LibraryCard.Created,
                    TopBranchName = branch.Name,
                    TopBranhImg = branch.ImageUrl

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

        public JsonResult ReportEachYear(int year)
        {
            var listCheckoutHistory = _checkout.getAll(year);
            int[] months = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            if (listCheckoutHistory.Any())
            {
                foreach (var checkout in listCheckoutHistory)
                {
                    int m = checkout.CheckedIn.Value.Month;
                    months[m - 1]++;
                }
            }
            return Json(new
            {
                Jan = months[0],
                Feb = months[1],
                Mar = months[2],
                Apr = months[3],
                May = months[4],
                Jun = months[5],
                Jul = months[6],
                Aug = months[7],
                Sep = months[8],
                Oct = months[9],
                Nov = months[10],
                Dec = months[11]
            });
        }
    }

}