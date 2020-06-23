using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Areas.Admin.Models.Branches;
using Library.Data.Models;
using Library.Models.Patron;
using LibraryData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Areas.Employee.Controllers
{
    [Area("Employee")]
   
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
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                var allPatrons = _patronService.GetAllPatrons();
                var patronModels = allPatrons
                    .Select(p => new PatronDetailModel
                    {
                        Id = p.Id,
                        LastName = p.LastName ?? "No First Name Provided",
                        FirstName = p.FirstName ?? "No Last Name Provided",
                        LibraryCardId = p.LibraryCard?.Id,
                        OverdueFees = p.LibraryCard?.Fees,
                        HomeLibrary = p.HomeLibraryBranch?.Name
                    }).ToList();

                var model = new PatronIndexModel
                {
                    Patrons = patronModels
                };
                return View(model);
            }   
        }

        public IActionResult Detail(int id)
        {
            var patron = _patronService.Get(id);

            var model = new PatronDetailModel
            {
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

            return View(model);
        }
        public IActionResult Add()
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
            //mess += branchList.ToArray().Length;
            // return Content(mess);
            return View();
        }
        [HttpPost]
        public JsonResult CheckUsername(string username, string email)
        {
            var result = _patronService.CheckUserExist(username, email);
            if (result) return Json("1");

            return Json("0");
        }
        [HttpPost]
        public IActionResult SubmitAdd(Patron patron)
        {
            patron.Password = "123456";
            LibraryCard libCard = new LibraryCard();
            var now = DateTime.Now;
            libCard.Fees = 0;
            libCard.Created = now;
            var idCard = _patronService.AddNewLibraryCard(libCard);
            patron.LibraryCardId = idCard;
            patron.RoleID = 3;
            _patronService.AddNewPatron(patron);
            var allPatrons = _patronService.GetAllPatrons();
            var patronModels = allPatrons
                .Select(p => new PatronDetailModel
                {
                    Id = p.Id,
                    LastName = p.LastName ?? "No First Name Provided",
                    FirstName = p.FirstName ?? "No Last Name Provided",
                    LibraryCardId = p.LibraryCard?.Id,
                    OverdueFees = p.LibraryCard?.Fees,
                    HomeLibrary = p.HomeLibraryBranch?.Name
                }).ToList();

            var model = new PatronIndexModel
            {
                Patrons = patronModels
            };
            return View("Index",model);
        }

        
        public IActionResult Login(Patron patron)
        {
            return View();
        }
    }
}