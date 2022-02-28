using Microsoft.AspNetCore.Mvc;

namespace Lab_06.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
