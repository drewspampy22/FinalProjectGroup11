using FinalProjectGroup11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace FinalProjectGroup11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MovieContext _context;

        // DbContext is injected here
        public HomeController(ILogger<HomeController> logger, MovieContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HarshPage() => View();

        public IActionResult DrewPage() => View();

        public IActionResult MuyiwaPage() => View();

        // ? This action pulls movies from the database and sends them to the view
        public IActionResult Database()
        {
            // If the DbSet exists, load movies ordered by Name
            List<Movie> movies;

            if (_context.Movies != null)
            {
                movies = _context.Movies
                                 .OrderBy(m => m.Name)
                                 .ToList();
            }
            else
            {
                movies = new List<Movie>();
            }

            // Pass the movie list to the view
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
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

