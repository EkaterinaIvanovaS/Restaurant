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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (DefaultDbContext db = new DefaultDbContext())
            {
                // получаем объекты из бд и выводим на консоль
                var categories = db.Categories.ToList();
                return View(categories);
            }
        }

        public IActionResult Info()
        {
            return View();
        }

        public IActionResult Stocks()
        {
            return View();
        }

        public IActionResult Delivery()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Footer()//For footer
        {
            using (DefaultDbContext db = new DefaultDbContext())
            {
                // получаем объекты из бд и выводим на консоль
                var categories = db.Categories.ToList();
                return View("~/ Views / Shared / FooterCategories.cshtml");
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
