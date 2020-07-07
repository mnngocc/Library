using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Areas.Admin.Models.Branches;
using Library.Data.Models;
using Library.Models.CheckoutModels;
using Library.Models.Patron;
using LibraryData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;

namespace Library.Controllers
{
    public class PatronController : Controller
    {
        private readonly IPatron _patronService;
        private readonly ILibraryBranchService _branch;

        public PatronController(IPatron patronService, ILibraryBranchService branch)
        {
            _patronService = patronService;
            _branch = branch;
          
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
                HttpContext.Session.SetInt32("role_id", patron_id.RoleID);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Login");
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
        public IActionResult EditInfo(int id)
        {
            var list = _branch.GetAll();
            IEnumerable<BranchDetailModel> ResultBranch = list.
                            Select(result => new BranchDetailModel
                            {
                                Id = result.Id,
                                Name = result.Name,
                            });
            List<BranchDetailModel> listBranch = ResultBranch.ToList();
            SelectList branchList = new SelectList(listBranch, "Id", "Name");
            ViewBag.branchList = branchList;         

            var patron = _patronService.Get(id);
            var model = new PatronDetailModel
            {
                Id = id,
                FirstName = patron.FirstName,
                LastName = patron.LastName,
                Address = patron.Address,
                Telephone = patron.TelephoneNumber,
                LibraryCardId = patron.LibraryCardId,
                Email = patron.Email,
                DateOfBirth = patron.DateOfBirth
            };
            return View(model);

        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(PatronDetailModel patron)
        {
            var data = _patronService.Get(patron.Id);
            if (ModelState.IsValid)
            {
                data.Id = patron.Id;
                data.FirstName = patron.FirstName;
                data.LastName = patron.LastName;
                data.TelephoneNumber = patron.Telephone;
                data.Email = patron.Email;
                data.Address = patron.Address;
                data.DateOfBirth = patron.DateOfBirth;
                data.HomeLibraryBranchId = patron.HomeLibraryBranchId;
                if (patron.Password != null)
                {
                    data.Password = patron.Password;
                }    
                bool result = _patronService.Update(data);
            }
            else
            {
                ViewBag.Error = "Missing value";
            }

            var patrondetail = _patronService.Get(patron.Id);
            var model = new PatronDetailModel
            {
                Id = patrondetail.Id,
                LastName = patrondetail.LastName ?? "No Last Name Provided",
                FirstName = patrondetail.FirstName ?? "No First Name Provided",
                Address = patrondetail.Address ?? "No Address Provided",
                HomeLibrary = patrondetail.HomeLibraryBranch?.Name ?? "No Home Library",
                MemberSince = patrondetail.LibraryCard?.Created,
                OverdueFees = patrondetail.LibraryCard?.Fees,
                LibraryCardId = patrondetail.LibraryCard?.Id,
                Telephone = string.IsNullOrEmpty(patrondetail.TelephoneNumber) ? "No Telephone Number Provided" : patrondetail.TelephoneNumber,
                AssetsCheckedOut = _patronService.GetCheckouts(patron.Id).ToList(),
                CheckoutHistory = _patronService.GetCheckoutHistory(patron.Id),
                Holds = _patronService.GetHolds(patron.Id)
            };
            return View("Profile", model);
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

        public JsonResult CheckCurrentPass(int id,string current)
        {
            var result = _patronService.CheckCurrentPass(id,current);
            if (result) return Json("0");

            return Json("1");
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
            patron.HomeLibraryBranchId = 1;
            patron.RoleID = 3;
            _patronService.AddNewPatron(patron);
            return View("Login");
        }

       
    }
}