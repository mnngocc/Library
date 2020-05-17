using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using Library.Areas.Admin.Models.Assets;
using Library.Areas.Admin.Models.Branches;
using Library.Areas.Admin.Models.Statuses;
using Library.Data.Models;
using Library.Models.Catalog;
using LibraryData;
using LibraryServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace Library.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AssetsController : Controller
    {
        private ILibraryAsset _asset;
        private IBook _assets;
        private IVideo _videos;
        private IStatus _statuses;
        private ILibraryBranchService _branch;
        private readonly IWebHostEnvironment he;

        public AssetsController(ILibraryAsset la,IBook assets, IVideo videos, IStatus stt, IWebHostEnvironment e, ILibraryBranchService branch)
        {
            _assets = assets;
            _videos = videos;
            _statuses = stt;
            he = e;
            _asset = la;
            _branch = branch;
        }
      
        public IActionResult ListBook()
        {         
            var assetModels = _assets.GetAll();
            var ListingResult = assetModels
                        .Select(result => new BookIndexListingModel
                        {
                            Id = result.Id,
                            ImageURL = result.ImageUrl,
                            AuthorOrDirector = _assets.GetAuthorOrDirector(result.Id),
                            DeweyCallNumber = _assets.GetDeweyIndex(result.Id),
                            Title = result.Title,
                            NumberOfCopies = result.NumberOfCopies.ToString(),
                            Year = result.Year.ToString(),
                            Status = result.Status.ToString(),
                            Cost = result.Cost.ToString(),                      
                            Location = _asset.GetCurrentLocation(result.Id)?.Name.ToString()
                           // Location = result.Location.Name
                        });
            var model = new BookIndexModel()
            {
                Books = ListingResult
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var assetModels = _statuses.GetAll();
            
            var ListingResult = assetModels
                        .Select(result => new StatusIndexListingModel
                        {
                            Id = result.Id,
                            Name = result.Name,
                            Description = result.Description
                        });
             var model_ = new StatusIndexModel()
            {
                Statuses = ListingResult,
               
             };
           
            return View(model_);
        }
        [HttpPost]
        public IActionResult Create(Book newBook, IFormFile ImageUrl)
        {
            if (ImageUrl != null)
            {
                newBook.ImageUrl = "/images/assets/" + ImageUrl.FileName;
                var fileName = Path.Combine(he.WebRootPath + "/images/assets", Path.GetFileName(ImageUrl.FileName));
                ImageUrl.CopyTo(new FileStream(fileName, FileMode.Create));
            }    
            _assets.Add(newBook);        
            //return Content(mess);
            return RedirectToAction("ListBook");
        }
        public IActionResult CreateVideo()
        {
            var assetModels = _statuses.GetAll();
            var ListingResult = assetModels
                        .Select(result => new StatusIndexListingModel
                        {
                            Id = result.Id,
                            Name = result.Name,
                            Description = result.Description
                        });
            var model_ = new StatusIndexModel()
            {
                Statuses = ListingResult
            };

            return View(model_);

        }
        [HttpPost]
        public IActionResult CreateVideo(Video newVid, IFormFile ImageUrl)
        {
            if (ImageUrl != null)
            {
                newVid.ImageUrl = "/images/assets/" + ImageUrl.FileName;
                var fileName = Path.Combine(he.WebRootPath + "/images/assets", Path.GetFileName(ImageUrl.FileName));
                ImageUrl.CopyTo(new FileStream(fileName, FileMode.Create));
            }
            _videos.Add(newVid);
         
            // return Content(mess);
            return RedirectToAction("ListVideo");
        }

        public IActionResult ListVideo()
        {
           
            var assetModels = _videos.GetAll();
            var ListingResult = assetModels
                        .Select(result => new VideoIndexListingModel
                        {
                            Id = result.Id,
                            ImageURL = result.ImageUrl,
                            AuthorOrDirector = _videos.GetAuthorOrDirector(result.Id),                           
                            Title = result.Title,
                            NumberOfCopies = result.NumberOfCopies.ToString(),
                            Year = result.Year.ToString(),
                            Status = result.Status.ToString(),
                            Cost = result.Cost.ToString(),
                            Location = _asset.GetCurrentLocation(result.Id)?.Name.ToString()    
                        });
            var model = new VideoIndexModel()
            {
                Videos = ListingResult
            };
             return View(model);
           // return Content(mess);
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult EditBook(int id)
        {
            var asset = _assets.GetById(id);
            var model = new BookDetailModel
            {
                AssetId = id,
                Title = asset.Title,        
                Year = asset.Year,
                Cost = asset.Cost,
                Status = asset.Status.Name,
                NumberOfCopies = asset.NumberOfCopies,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = _assets.GetAuthorOrDirector(id), //Ham duoc viet cho lop Interface -  Services
                Dewey = _assets.GetDeweyIndex(id),
                ISBN = _assets.GetIsbn(id)
            };
            return View(model);
        }

        public IActionResult EditVideo(int id)
        {
          
            var video = _videos.GetById(id);
            var video_model = new VideoDetailModel
            {
                AssetId = id,
                Title = video.Title,
                Year = video.Year,
                Cost = video.Cost,
                Status = video.Status.Name,
                NumberOfCopies = video.NumberOfCopies,
                ImageUrl = video.ImageUrl,
                AuthorOrDirector = video.Director

            };
            //return Content(mess);
            return View(video_model);
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult Update(BookDetailModel asset, IFormFile ImageUrl)
        {
            string message = "";
            var data = _assets.GetById(asset.AssetId);
            if (ImageUrl != null)
            {
                asset.ImageUrl = "/images/assets/" + ImageUrl.FileName;
                data.ImageUrl = asset.ImageUrl;
                var fileName = Path.Combine(he.WebRootPath + "/images/assets", Path.GetFileName(ImageUrl.FileName));
                ImageUrl.CopyTo(new FileStream(fileName, FileMode.Create));
            }
            if (ModelState.IsValid)
            {
                data.Title = asset.Title;
                data.Author = asset.AuthorOrDirector;
                data.DeweyIndex = asset.Dewey;
                data.NumberOfCopies = asset.NumberOfCopies;
                data.Year = asset.Year;
                data.Cost = asset.Cost;
                
                bool result = _assets.Update(data);
                if (result)
                {
                    message += "Successfully";
                }
                else
                {
                    message += "Result return false";
                }
            }
           
            //return Content(message);
            return RedirectToAction("ListBook");
        }

        public IActionResult AddBook()
        {
            string mess = "";
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
            mess += branchList.ToArray().Length;
           // return Content(mess);
            return View();

        }
        public IActionResult AddVideo()
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
            return View();
        }

        public IActionResult Delete(int id)
        {     
            string type_ = _asset.GetType(id);
            if (type_.Equals("Book"))
            {
                _asset.Remove(id);
                return RedirectToAction("ListBook");
            }    
            else
            {
                _asset.Remove(id);
                return RedirectToAction("ListVideo");
            }    
        }

        public IActionResult UpdateVideo(VideoDetailModel asset, IFormFile ImageUrl)
        {
            string message = "";

            var data = _videos.GetById(asset.AssetId);
            if (ImageUrl != null)
            {
                asset.ImageUrl = "/images/assets/" + ImageUrl.FileName;
                data.ImageUrl = asset.ImageUrl;
                var fileName = Path.Combine(he.WebRootPath + "/images/assets", Path.GetFileName(ImageUrl.FileName));
                ImageUrl.CopyTo(new FileStream(fileName, FileMode.Create));
            }
            if (ModelState.IsValid)
            {
                data.Title = asset.Title;
                data.Director = asset.AuthorOrDirector;
                data.NumberOfCopies = asset.NumberOfCopies;
                data.Year = asset.Year;
                data.Cost = asset.Cost;
                bool result = _videos.Update(data);
                if (result)
                {
                    message += "Successfully";
                }
                else
                {
                    message += "Result return false";
                }
            }
            else
            {
                message += "Fail to update";
            }
            // return Content(message);
            return RedirectToAction("ListVideo");
        }
    }
}