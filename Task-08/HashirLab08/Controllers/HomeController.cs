using System.Diagnostics;
using HashirLab08.Models;
using Microsoft.AspNetCore.Mvc;

namespace HashirLab08.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var students = new List<(string Name, int Age, string Grade)>
            {
                ("ABC" ,20,"A"),
                ("DEF" ,20,"B"),
                ("GHI" ,20,"C"),
                ("XYZ" ,20,"A+"),
            };

            ViewData["Students"] = students;

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
