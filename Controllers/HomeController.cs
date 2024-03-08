using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mission6_burrows.Models;
using NuGet.Protocol.Plugins;
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
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        public IActionResult Table() // generates the movie table view
        {
            var stuff = _context.Movies.Include(x => x.Category).ToList();
            return View("Table", stuff);
        }

        [HttpPost]
        public IActionResult Movies(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
                return View("Confirmation");
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();
                return View(response);
            }
        }

        public IActionResult Joel()
        {
            return View();
        }

        public IActionResult AllMovies()
        {
            var movies = _context.Movies.Include("Category")
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var MovieToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("Movies", MovieToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie response)
        {
            _context.Update(response);
            _context.SaveChanges();

            return RedirectToAction("Table");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var record = _context.Movies.Single(x => x.MovieId == id);
            return View(record);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("Table");
        }
    }
}
