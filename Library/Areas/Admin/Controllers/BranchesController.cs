using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Library.Areas.Admin.Models.Branches;
using Library.Data.Models;
using LibraryData;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BranchesController : Controller
    {
        private ILibraryBranchService _branch;
        private readonly IWebHostEnvironment he;
        public BranchesController(ILibraryBranchService branch, IWebHostEnvironment e)
        {
            _branch = branch;
            he = e;
        }
        public IActionResult CreateBranch(LibraryBranch newBranch, IFormFile ImageUrl)
        {
            newBranch.ImageUrl = "/images/branch/" + ImageUrl.FileName;
            _branch.Add(newBranch);
            if (ImageUrl != null)
            {
                var fileName = Path.Combine(he.WebRootPath + "/images/branch", Path.GetFileName(ImageUrl.FileName));
                ImageUrl.CopyTo(new FileStream(fileName, FileMode.Create));
            }
            return RedirectToAction("ListBranch");
        }
        public IActionResult AddBranch(LibraryBranch newBranch, IFormFile ImageUrl)
        {
            return View();
        }
            public IActionResult ListBranch()
        {
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
                           OpenDate = result.OpenDate,           
                           NumberOfAssets = _branch.GetAssetCount(result.Id),
                           NumberOfPatrons = _branch.GetPatronCount(result.Id),
                           IsOpen = _branch.IsBranchOpen(result.Id)
                           
                       });
            var model_branch = new BranchIndexModel()
            {
                Branches = List
            };
            return View(model_branch);
        }
        public IActionResult Delete(int id)
        {
            _branch.Remove(id);
            return RedirectToAction("ListBranch");
        }

        public IActionResult EditBranch(int id)
        {
            var branch = _branch.GetById(id);
            var model = new BranchDetailModel
            {
                Id = branch.Id,
                ImageURL = branch.ImageUrl,
                Name = branch.Name,
                Address = branch.Address,
                Telephone = branch.Telephone,
                Description = branch.Description,
                OpenDate = branch.OpenDate
            };
            return View(model);
        }


        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(BranchDetailModel branch, IFormFile ImageUrl)
        {
            string message = "";
            var data = _branch.GetById(branch.Id);
                data.Id = branch.Id;
                data.Name = branch.Name;
                data.Address = branch.Address;
                data.Telephone = branch.Telephone;
                data.Description = branch.Description;
                data.OpenDate = branch.OpenDate;

            if (ImageUrl != null)
            {
                branch.ImageURL = "/images/branch/" + ImageUrl.FileName;
                data.ImageUrl = branch.ImageURL;
                var fileName = Path.Combine(he.WebRootPath + "/images/branch", Path.GetFileName(ImageUrl.FileName));
                ImageUrl.CopyTo(new FileStream(fileName, FileMode.Create));
            }
            bool result = _branch.Update(data);
            if (result)
            {
                message += "Update succesfully!";
            }    
            else
            {
                message += "Fail to update";
            }    
             //return Content(message);
            return RedirectToAction("ListBranch");
        }
    }
}