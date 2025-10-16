using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents.UI
{
    public class _UIScriptsComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
