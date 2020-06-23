using Library.Data.Models;
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
        public HomeController(IPatron patron)
        {
            _patronService = patron;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("username") != null)
                return View();
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

                return View("Index");
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