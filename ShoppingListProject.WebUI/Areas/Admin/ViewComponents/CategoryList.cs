using Microsoft.AspNetCore.Mvc;
using ShoppingListProject.BusinessLayer.Manager;
using ShoppingListProject.DataLayer.EF;

namespace ShoppingListProject.WebUI.Areas.Admin.ViewComponents
{
    public class CategoryList : ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var entity = cm.GetList();
            return View(entity);
        }
    }
}
