using Microsoft.AspNetCore.Mvc;

namespace Middleware.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Data = "Fsociety";

            ViewBag.list=new List<string>()
            {
                "Ali","Ahmed","Daniel"
            };

            TempData["temp"] = "I am Temp Data";
            TempData.Keep("temp");
            return View();
        }
        public int ID(int id)
        {
            return id;
        }
        public ContentResult ContentResult(){
            return Content("Hello this is content");
        }
        public JsonResult Data(int id){
            return Json(new {data=id });
        }
    }
}
