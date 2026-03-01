using Microsoft.AspNetCore.Mvc;

namespace Middleware.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Hamza";
            ViewData["ID"] = "24-Arid-1044";
            ViewData["Date"] = DateTime.Now.ToLongDateString();

            string[] array = { "A", "B", "C" };
            ViewData["alpha"] = array;

            TempData.Keep();
            return View();
        }
        public IActionResult Detail()
        {
            TempData.Keep("temp");
            return View();
        }
    }
}
