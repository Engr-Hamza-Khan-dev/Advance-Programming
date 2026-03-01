using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<StudentsModel>()
            {
                new StudentsModel{Id=34,Name="Hamza",Gender="Male",Standard="4th Sem"},
                new StudentsModel{Id=44,Name="Muzzi",Gender="Gay",Standard="4th Sem"},
                new StudentsModel{Id=54,Name="Taha",Gender="Lesbian",Standard="4th Sem"}
            };
            ViewBag.Students = students;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
