using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers
{
    [Route("[Controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("/Home")]
        public IActionResult Index()
        {
            return View();
        }
       
        [Route("{id?}")]
        public IActionResult Detail(int? id)
        {
            return id??25;
        }
    }
}
