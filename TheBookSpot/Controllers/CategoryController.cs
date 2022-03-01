using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheBookSpot.Data;
using TheBookSpot.Models;

namespace TheBookSpot.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> catList = _db.Categories;

            return View(catList);
        }

        public IActionResult Create()
        {

            return View();
        }
    }
}
