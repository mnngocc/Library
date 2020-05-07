using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Models;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace Library.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BranchesController : Controller
    {
        private ILibraryBranchService _branch;
        public BranchesController(ILibraryBranchService branch)
        {
            _branch = branch;
        }
        public IActionResult ListBranch()
        {
            return View();
        }
    }
}