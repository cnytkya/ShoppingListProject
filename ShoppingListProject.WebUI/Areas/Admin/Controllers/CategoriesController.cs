using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using ShoppingListProject.BusinessLayer.Manager;
using ShoppingListProject.BusinessLayer.ValidationRules;
using ShoppingListProject.DataLayer.Context;
using ShoppingListProject.DataLayer.EF;
using ShoppingListProject.DataLayer.Repositories;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        private readonly IGenericRepository<Category> _genericRepository;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = cm.GetById(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult validationResult = cv.Validate(category);
            if (ModelState.IsValid)
            {
                cm.Update(category);
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(Category category)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        cm.Update(category);
        //        return RedirectToAction(nameof(Index));
        //    }

        //    // Doğrulama hataları varsa, buraya gelir.
        //    foreach (var modelState in ViewData.ModelState.Values)
        //    {
        //        foreach (var error in modelState.Errors)
        //        {
        //            ModelState.AddModelError("", error.ErrorMessage);
        //        }
        //    }

        //    return View(category);
        //}



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Activate(int id)
        {
            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            //category.IsActive = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deactivate(int id)
        {
            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            //category.IsActive = false;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
