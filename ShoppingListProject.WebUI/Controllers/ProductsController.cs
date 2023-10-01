using Microsoft.AspNetCore.Mvc;
using ShoppingListProject.BusinessLayer.Manager;
using ShoppingListProject.BusinessLayer.Service;
using ShoppingListProject.DataLayer.EF;
using ShoppingListProject.EntityLayer;

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

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddProduct(Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            // Ürünü veritabanına eklemek için gerekli işlemleri yapın
        //            productService.Add(product);

        //            // Eğer ekleme işlemi başarılı ise, kullanıcıyı başka bir sayfaya yönlendirin
        //            return RedirectToAction("Index", "Home");
        //        }
        //        catch (Exception ex)
        //        {
        //            // Hata durumunda buraya düşecek
        //            // Loglama veya hata mesajı gösterimi gibi işlemler burada yapılabilir

        //            ModelState.AddModelError(string.Empty, "Bir hata oluştu. Lütfen tekrar deneyiniz.");
        //            return View(product); // Kullanıcıyı tekrar aynı sayfaya gönderiyoruz
        //        }
        //    }

        //    // Eğer ModelState geçersiz ise, yani form hatalı doldurulmuşsa, hata mesajları ile birlikte aynı sayfaya geri döndürün
        //    return View(product);
        //}
    }
}
