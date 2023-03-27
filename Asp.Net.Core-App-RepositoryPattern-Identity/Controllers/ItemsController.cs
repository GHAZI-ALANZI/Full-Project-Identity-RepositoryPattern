using Asp.Net.Core_App_RepositoryPattern_Identity.Data;
using Asp.Net.Core_App_RepositoryPattern_Identity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.Core_App_RepositoryPattern_Identity.Controllers
{
    public class ItemsController : Controller
    {
        public ItemsController(AppDbContext db)
        {
            _db = db;
        }

        private readonly AppDbContext _db;
        public IActionResult Index()
        {
            IEnumerable<Item> itemsList = _db.Items.ToList();
            return View(itemsList);
        }
    }
}
