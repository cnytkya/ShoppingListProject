using Microsoft.AspNetCore.Mvc;
using ShoppingListProject.BusinessLayer.Manager;
using ShoppingListProject.DataLayer.Context;
using ShoppingListProject.DataLayer.EF;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());

        public IActionResult Index()
        {
            List<Product> products = pm.GetList();
            return View(products);
        }
    }
}
