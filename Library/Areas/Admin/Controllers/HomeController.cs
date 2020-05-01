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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditBook()
        {
            return View();
        }
    }
}