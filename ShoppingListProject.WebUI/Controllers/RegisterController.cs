using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using ShoppingListProject.BusinessLayer.Manager;
using ShoppingListProject.BusinessLayer.ValidationRules;
using ShoppingListProject.DataLayer.EF;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        UserManager um = new UserManager(new EfUserRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            UserValidator uv = new UserValidator();
            ValidationResult results = uv.Validate(user);
            if (results.IsValid)
            {
                user.IsActive = true;
                um.Add(user);
                return RedirectToAction("Index", "Products");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
