using Microsoft.AspNetCore.Mvc;
using ShoppingListProject.BusinessLayer.Manager;
using ShoppingListProject.DataLayer.EF;

namespace ShoppingListProject.WebUI.Areas.Admin.ViewComponents
{
    public class ListProductOnDashboard :ViewComponent
    {
        ProductManager bm = new ProductManager(new EfProductRepository());
        public IViewComponentResult Invoke()
        {
            var entity = bm.GetProductWithCategory();
            return View(entity);
        }
    }
}
