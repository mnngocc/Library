using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Library.Data.Models;
using Library.Models.Catalog;
using LibraryData;
using LibraryServices;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc;
namespace Library.Controllers
{
    public class CatalogController : Controller
    {
        private ILibraryAsset _assets;
        public CatalogController(ILibraryAsset assets)
        {
            _assets = assets;
        }

        public IActionResult Index()
        {
            var assetModels = _assets.GetAll();
            var ListingResult = assetModels
                        .Select(result => new AssetIndexListingModel
                        {
                            Id = result.Id,
                            ImageURL = result.ImageUrl,
                            AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                            DeweyCallNumber = _assets.GetDeweyIndex(result.Id),
                            Title = result.Title, 
                            Type = _assets.GetType(result.Id)
                        });
            var model = new AssetIndexModel()
            {
                Assets = ListingResult
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var asset = _assets.GetById(id);
          
            var model = new AssetDetailModel
            {
                AssetId = id,
                Title = asset.Title,
                Type = _assets.GetType(id),
                Year = asset.Year,
                Cost = asset.Cost,
                Status = asset.Status.Name,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = _assets.GetAuthorOrDirector(id), //Ham duoc viet cho lop Interface -  Services
                CurrentLocation = _assets.GetCurrentLocation(id)?.Name,
                Dewey = _assets.GetDeweyIndex(id),
                Isbn = _assets.GetIsbn(id)
               
            };
            return View(model);
        }

        
    }
}
