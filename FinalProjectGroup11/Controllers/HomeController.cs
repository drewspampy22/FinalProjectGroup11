using System.Diagnostics;
using FinalProjectGroup11.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectGroup11.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DrewPage()
        {
            return View("DrewPage");
        }
        public IActionResult HarshPage()
        {
            return View("HarshPage");
        }
        public IActionResult MuyiwaPage()
        {
            return View("MuyiwaPage");
        }
        public IActionResult Database()
        {
            return View("Database");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
