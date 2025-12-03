using FinalProjectGroup11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProjectGroup11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MovieContext _context;

        public HomeController(ILogger<HomeController> logger, MovieContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() => View();
        public IActionResult Privacy() => View();
        public IActionResult DrewPage() => View();
        public IActionResult HarshPage() => View();
        public IActionResult MuyiwaPage() => View();
        public IActionResult Database() => View("Database");

        public IActionResult DrewsFavoriteMovies()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
