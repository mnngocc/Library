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
            if (HttpContext.Session.GetString("username") != null)
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


    }

}