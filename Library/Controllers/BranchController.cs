﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Areas.Admin.Models.Branches;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
  
   
    public class BranchController : Controller
    {
        private readonly ILibraryBranchService _branchService;

        public BranchController(ILibraryBranchService branchService)
        {
            _branchService = branchService;
        }
       
        public IActionResult Index()
        {
            var branchModels = _branchService.GetAll()
                .Select(br => new BranchDetailModel
                {
                    Id = br.Id,
                    Name = br.Name,
                    NumberOfAssets = _branchService.GetAssetCount(br.Id),
                    NumberOfPatrons = _branchService.GetPatronCount(br.Id),
                    IsOpen = _branchService.IsBranchOpen(br.Id)
                }).ToList();

            var model = new BranchIndexModel
            {
                Branches = branchModels
            };

            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var branch = _branchService.Get(id);
            var model = new BranchDetailModel
            {
                Name = branch.Name,
                Description = branch.Description,
                Address = branch.Address,
                Telephone = branch.Telephone,
                ImageURL = branch.ImageUrl,
                BranchOpenedDate = branch.OpenDate.ToString("yyyy-MM-dd"),
                NumberOfPatrons = _branchService.GetPatronCount(id),
                NumberOfAssets = _branchService.GetAssetCount(id),
                TotalAssetValue = _branchService.GetAssetsValue(id),
          
                HoursOpen = _branchService.GetBranchHours(id),
                AssetsTitle = _branchService.GetAssetsTitle(id)

            };

            return View(model);
        }
    }
}