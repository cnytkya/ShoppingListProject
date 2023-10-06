using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingListProject.BusinessLayer.Manager;
using ShoppingListProject.BusinessLayer.ValidationRules;
using FluentValidation.Results;
using ShoppingListProject.DataLayer.EF;
using ShoppingListProject.EntityLayer;
using System.Configuration;
using System.Reflection.Metadata;
using ShoppingListProject.DataLayer.Context;
using Microsoft.AspNetCore.Authorization;

namespace ShoppingListProject.WebUI.Areas.Admin.Controllers
{
    //[Authorize]
    [Area("Admin")]
    public class ProductsController : Controller
    {
        AppDbContext dc = new AppDbContext();
        ProductManager pm = new ProductManager(new EfProductRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            ICollection<Product> products = pm.GetList();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<Category> categories = cm.GetList();
            List<SelectListItem> categoryItems = categories
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.CategoryId.ToString()
                })
                .ToList();

            ViewBag.CategoryList = categoryItems;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            ProductValidator pv = new ProductValidator();
            ValidationResult validationResult = pv.Validate(product);

            if (validationResult.IsValid)
            {
                if (string.IsNullOrEmpty(product.Image))
                {
                    product.Image = "default.jpg"; // Varsayılan bir resim adı
                }
                //product.Status = true;
                product.CreateDate = DateTime.Now;
                pm.Add(product);
                dc.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = pm.GetById(id);
            List<Category> categories = cm.GetList();

            if (product == null)
            {
                return NotFound();
            }

            List<SelectListItem> categoryItems = categories
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.CategoryId.ToString(),
                    Selected = x.CategoryId == product.CategoryId // Kategoriyi seçili olarak işaretle
                })
                .ToList();

            ViewBag.CategoryList = categoryItems;

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductValidator pv = new ProductValidator();
            ValidationResult validationResult = pv.Validate(product);

            if (validationResult.IsValid)
            {
                if (string.IsNullOrEmpty(product.Image))
                {
                    product.Image = "default.jpg";
                }

                product.CreateDate = DateTime.Now;

                pm.Update(product);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View(product);
        }


    }
}
