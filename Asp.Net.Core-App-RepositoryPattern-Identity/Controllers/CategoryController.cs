using Asp.Net.Core_App_RepositoryPattern_Identity.Models;
using Asp.Net.Core_App_RepositoryPattern_Identity.Repository.Base;
using Microsoft.AspNetCore.Mvc;

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
        }
    }
}
