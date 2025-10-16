using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Models;

namespace ShoppingMongo.ViewComponents.UI
{
    public class _UIFooterComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new MailViewModel());
        }
    }
}
