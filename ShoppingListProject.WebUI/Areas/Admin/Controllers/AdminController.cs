using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingListProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public PartialViewResult AdminNavBarPartial()
        {
            return PartialView();
        }
    }
}
