using Microsoft.AspNetCore.Mvc;
using ShoppingListProject.BusinessLayer.Manager;
using ShoppingListProject.DataLayer.EF;

namespace ShoppingListProject.WebUI.Areas.Admin.ViewComponents.Admin
{
    public class AdminMessageNotification : ViewComponent
    {
        MessageManager mm = new MessageManager(/*new EfMessageRepository()*/);
        public IViewComponentResult Invoke()
        {
            int id = 2;
            //p = "deneme2542@gmail.com"; //burası aslında session dan gelen bir değer olacak
            var values = mm.GetInboxList(id);
            return View(values);
        }
    }
}
