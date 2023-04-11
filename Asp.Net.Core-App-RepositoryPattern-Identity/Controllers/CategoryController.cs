﻿using Asp.Net.Core_App_RepositoryPattern_Identity.Models;
using Asp.Net.Core_App_RepositoryPattern_Identity.Repository.Base;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Asp.Net.Core_App_RepositoryPattern_Identity.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryController(IRepository<Category> repository)
        {
            _repository = repository;
        }

        private IRepository<Category> _repository;

        public async Task<IActionResult> Index()
        {
            return View(await _repository.FindAllAsync());
            var oneCat = _repository.SelectOne(x => x.Name == "Computers");

            var allCat = await _repository.FindAllAsync("Items");

            return View(allCat);
        }

        //GET
        public IActionResult New()
        {


            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.clientFile != null)
                {
                    MemoryStream stream = new MemoryStream();
                    category.clientFile.CopyTo(stream);
                    category.dbImage = stream.ToArray();
                }
                _repository.AddOne(category);
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
        }

        //GET
        public IActionResult Edit(int? Id)
        {

            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var category = _repository.FindById(Id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateOne(category);
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
        }

        //GET
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var category = _repository.FindById(Id.Value);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Category category)
        {

            _repository.DeleteOne(category);
            TempData["successData"] = "category has been deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
