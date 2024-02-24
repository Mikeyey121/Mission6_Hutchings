using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelTest.Models;
using MusicApplication.Models;
using SQLitePCL;
using System.Diagnostics;

namespace MovieModel.Controllers
{
    public class HomeController : Controller
    {
        private MusicContext _context;
        public HomeController(MusicContext movies) {
            _context = movies;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View(new Movies());
        }

        [HttpPost]
        public IActionResult Form(Movies response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Index");
            }
            else
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
                return View(response);
            }
            
        }
        
        public IActionResult Waitlist ()
        {
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        public IActionResult test()
        {
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var record = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("Form",record);
        }
        [HttpPost]
        public IActionResult Edit(Movies movie)
        {
            _context.Update(movie);
            _context.SaveChanges();
            return RedirectToAction("test");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var record = _context.Movies
                .Single(x => x.MovieId == id);

            

            return View(record);
        }
        [HttpPost]
        public IActionResult Delete(Movies delete)
        {
            _context.Movies.Remove(delete);
            _context.SaveChanges();

            return RedirectToAction("test");
        }
    }
}
