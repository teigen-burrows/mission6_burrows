using Microsoft.AspNetCore.Mvc;
using mission6_burrows.Models;
using System.Diagnostics;
using System.Security.AccessControl;

namespace mission6_burrows.Controllers
{
    public class HomeController : Controller
    {
        private mission6_context _context;

        public HomeController(mission6_context blah) // connects the database to the app
        {
            _context = blah;
        }

        private readonly ILogger<HomeController> _logger;

        public IActionResult Index() // generates the home view
        {
            return View();
        }

        public IActionResult Privacy() // generates the getting to know you view
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies() // generates the movie view
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieForm response) // adds to database, saves response, prints confirmation view
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Confirmation");
        }
    }
}
