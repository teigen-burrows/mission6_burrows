using Microsoft.AspNetCore.Mvc;
using mission6_burrows.Models;
using System.Diagnostics;
using System.Security.AccessControl;

namespace mission6_burrows.Controllers
{
    public class HomeController : Controller
    {
        private mission6_context _context;

        public HomeController(mission6_context blah)
        {
            _context = blah;
        }

        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieForm response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Confirmation");
        }
    }
}
