using Microsoft.AspNetCore.Mvc;

namespace ShoppingListProject.WebUI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
