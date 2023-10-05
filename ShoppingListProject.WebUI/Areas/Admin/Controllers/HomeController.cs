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
            AppDbContext dbContext = new AppDbContext();
            ViewBag.v1 = dbContext.Products.Count().ToString();
            //ViewBag.v2 = dbContext.Products.Where(x => x.UserId == 1).Count();
            ViewBag.v3 = dbContext.Categories.Count().ToString();
            return View();
            //List<Product> products = pm.GetList();
            //return View(products);

        }
    }
}
