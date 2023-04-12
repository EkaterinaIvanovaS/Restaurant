using Dal.DbModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant2.Controllers
{
    public class MenuController : Controller
    {
        private readonly ILogger<MenuController> _logger;

        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
        }

        public IActionResult Menu(int categoryId)
        {
            using (DefaultDbContext db = new DefaultDbContext())
            {
                // получаем объекты из бд
                ViewData["Category"] = db.Categories.Single(item => categoryId == item.Id).Name;
                

                //ViewData["Category"] = categoryId;
                var products = db.Products.Where(item => categoryId == item.CategoryId).ToList();
                return View(products);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Cart()
        {
            return View();
        }

        [HttpPost]

        public IActionResult GetProducts(string idItems)
        {
            if (idItems == null)
            {
                return null;
            }
            var ids = idItems.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(p => int.Parse(p));
            using (DefaultDbContext db = new DefaultDbContext())
            {
                var products = db.Products.Where(item => ids.Contains(item.Id)).ToList();
                return Json(products);
            }
        }
    }
}
