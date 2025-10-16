using Microsoft.AspNetCore.Mvc;

namespace ShoppingMongo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
