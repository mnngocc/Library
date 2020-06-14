using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Models;
using Library.Models.Patron;
using LibraryData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class PatronController : Controller
    {
        private readonly IPatron _patronService;

        public PatronController(IPatron patronService)
        {
            _patronService = patronService;
        }

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SubmitLogin(Patron patron)
        {         
            bool result = _patronService.Authorize(patron.Username, patron.Password);
            if (result)
            {
                HttpContext.Session.SetString("username", patron.Username);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View( "Login");
            }                
            
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult RegisterForm()
        {

            return View();
        }

    }
}