using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ShoppingListProject.DataLayer.Context;
using ShoppingListProject.EntityLayer;
using System.Security.Claims;

namespace ShoppingListProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            AppDbContext dbContext = new AppDbContext();
            var entity = dbContext.Users.FirstOrDefault(x=>x.Email == user.Email && x.Password==user.Password);
            if (entity != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Email)
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }

    }
}
