using Dal.DbModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp.Components
{
    public class FooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            using (DefaultDbContext db = new DefaultDbContext())
            {
                // получаем объекты из бд и выводим на консоль
                var categories = db.Categories.ToList();
                return View("Footer", categories);
            }
        }
    }
}