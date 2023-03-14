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
                // �������� ������� �� �� � ������� �� �������
                var categories = db.Categories.ToList();
                return View("Footer", categories);
            }
        }
    }
}