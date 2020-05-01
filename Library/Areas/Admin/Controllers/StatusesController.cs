using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Areas.Admin.Models.Statuses;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace Library.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatusesController : Controller
    {
        private  IStatus _status;
        public StatusesController(IStatus status)
        {
            _status = status;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListStatus()
        {
           var assetModels = _status.GetAll();
            var ListingResult = assetModels
                        .Select(result => new StatusIndexListingModel
                        {
                            Id = result.Id,
                            Name = result.Name,
                            Description = result.Description
                        });
            var model = new StatusIndexModel()
            {
                Statuses = ListingResult
            };
            return View(model);
        }
    
    }
}