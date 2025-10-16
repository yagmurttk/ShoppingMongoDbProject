using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.ViewComponents.UI
{
    public class _UIHeaderComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
