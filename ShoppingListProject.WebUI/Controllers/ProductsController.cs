using Microsoft.AspNetCore.Mvc;
using ShoppingListProject.BusinessLayer.Manager;
using ShoppingListProject.DataLayer.EF;

namespace ShoppingListProject.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());

        public IActionResult Index()
        {
            var entity = pm.GetList();
            return View(entity);
        }

        public IActionResult Details(int id)
        {
            ViewBag.Id = id;
            var entity = pm.GetProductById(id);
            return View(entity);

        }
    }
}
