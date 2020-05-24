using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models.Catalog;
using LibraryData;
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
                            Type = _assets.GetType(result.Id),
                            CurrentLocation = _assets.GetCurrentLocation(result.Id)?.Name
                            
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
    }
}