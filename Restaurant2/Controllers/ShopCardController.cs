using Dal.DbModels;
using Microsoft.AspNetCore.Mvc;
using Restaurant2.Views.Models;
using System.Linq;
using Dal.Interfaces;

namespace Restaurant2.Controllers
{
    public class ShopCardController : Controller
    {
        private readonly IAllProducts _productRep;

        public ShopCardController(IAllProducts productRep)
        {
            _productRep = productRep;
        }
        //public ViewResult Index()
        //{
        //    var items = _shopCard.GetShopItems();
        //    _shopCard.shopCardItems = items;

        //    var obj = new ShopCardViewModel
        //    {
        //        shopCard = _shopCard
        //    };

        //    return View(obj);
        //}

        //public RedirectToActionResult addToCard(int id) //Изменение view при добавлении или удалении товара
        //{
        //    var item = _productRep.Products.FirstOrDefault(i => i.Id == id);
        //    if (item == null)
        //    {
        //        _shopCard.AddToProduct(item);
        //    }
        //    return RedirectToAction("Index");
        //}
    }
}
