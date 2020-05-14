using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Library.Data.Models;
using Library.Models.Catalog;
using Library.Models.CheckoutModels;
using LibraryData;
using LibraryServices;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc;
namespace Library.Controllers
{
    public class CatalogController : Controller
    {
        private ILibraryAsset _assets;
        private ICheckout _checkouts;
        public CatalogController(ILibraryAsset assets, ICheckout checkouts)
        {
            _assets = assets;
            _checkouts = checkouts;
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
            var currentHolds = _checkouts.GetCurrentHold(id)
                .Select(a => new AssetHoldModel
                { 
                    HoldPlaced = _checkouts.GetCurrentHoldPlaced(a.Id).ToString(),
                    PatronName = _checkouts.GetCurrentHoldPatron(a.Id)
                });
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
                Isbn = _assets.GetIsbn(id),
                CheckoutHistory = _checkouts.GetCheckoutHistory(id),
                CurrentAssociatedLibraryCard = _assets.GetLibraryCardByAssetId(id),
                LatestCheckout = _checkouts.GetLatestCheckout(id),
                PatronName = _checkouts.GetCurrentPatron(id),
                CurrentHolds = currentHolds             
            };
            return View(model);
        }

   
        public IActionResult Checkout(int id) //Muon sach
        {
            var asset = _assets.Get(id);

            var model = new CheckoutModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                IsCheckedOut = _checkouts.IsCheckedOut(id)
            };
            return View(model);

        }
        public IActionResult MarkLost(int id) //Danh dau sach bi mat
        {
            _checkouts.MarkLost(id);
            return RedirectToAction("Detail", new { id });

        }

        
        public IActionResult Hold(int id) //Giu sach
        {
            var asset = _assets.Get(id);

            var model = new CheckoutModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Title = asset.Title,
                LibraryCardId = "",
                HoldCount = _checkouts.GetCurrentHold(id).Count()
            };
            return View(model);

        }

        public IActionResult CheckIn(int id) //Tra sach
        {
             _checkouts.CheckInItem(id);
            return RedirectToAction("Detail", new {id});
        }

       
        public IActionResult MarkFound(int id)
        {
            _checkouts.MarkFound(id);
            return RedirectToAction("Detail", new {id});
        }
       
        [HttpPost]
        public IActionResult PlaceCheckout(int assetId, int libraryCardId)
        {
            _checkouts.CheckoutItem(assetId, libraryCardId);
            return RedirectToAction("Detail", new { id = assetId });
        }

        [HttpPost]
        public IActionResult PlaceHold(int assetId, int libraryCardId)
        {
            _checkouts.PlaceHold(assetId, libraryCardId);
            return RedirectToAction("Detail", new { id = assetId });
        }
    }
}
