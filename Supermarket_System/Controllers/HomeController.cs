using Microsoft.AspNetCore.Mvc;

namespace Supermarket_System.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
