using Microsoft.AspNetCore.Mvc;

namespace Lab_06.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
