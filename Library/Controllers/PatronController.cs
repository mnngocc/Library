using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Models;
using Library.Models.CheckoutModels;
using Library.Models.Patron;
using LibraryData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

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
            var patron_id = _patronService.GetByUsername(patron.Username);
          
            if (result)
            {
               
                HttpContext.Session.SetString("username", patron.Username);
                HttpContext.Session.SetInt32("id", patron_id.Id);
                HttpContext.Session.SetInt32("LibraryCard", patron_id.LibraryCard.Id);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View( "Login");
            }                
            
        }
       
        public IActionResult Profile(int id)
        {
            string msg = "";
            var patron = _patronService.Get(id);
           
            msg += HttpContext.Session.GetString("username");
            var model = new PatronDetailModel
            {
                Username = patron.Username,
                Id = patron.Id,
                LastName = patron.LastName ?? "No Last Name Provided",
                FirstName = patron.FirstName ?? "No First Name Provided",
                Address = patron.Address ?? "No Address Provided",
                HomeLibrary = patron.HomeLibraryBranch?.Name ?? "No Home Library",
                MemberSince = patron.LibraryCard?.Created,
                OverdueFees = patron.LibraryCard?.Fees,
                LibraryCardId = patron.LibraryCard?.Id,
                Telephone = string.IsNullOrEmpty(patron.TelephoneNumber) ? "No Telephone Number Provided" : patron.TelephoneNumber,
                AssetsCheckedOut = _patronService.GetCheckouts(id).ToList(),
                CheckoutHistory = _patronService.GetCheckoutHistory(id),
                Holds = _patronService.GetHolds(id)

            };
           // return Content(msg);
            return View(model);
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]

        public JsonResult CheckUsername(string username, string email )
        {           
            var result = _patronService.CheckUserExist(username, email);
            if (result) return Json("1");
            
            return Json("0");
        }
        public IActionResult RegisterForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitRegister(Patron patron)
        {
            LibraryCard libCard = new LibraryCard();
            var now = DateTime.Now;
            libCard.Fees = 0;
            libCard.Created = now;
            var idCard = _patronService.AddNewLibraryCard(libCard);
            patron.LibraryCardId = idCard;
            patron.RoleID = 3;
            _patronService.AddNewPatron(patron);
            return View("Login");
        }

       
    }
}