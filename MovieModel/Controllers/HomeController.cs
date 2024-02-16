using Microsoft.AspNetCore.Mvc;
using ModelTest.Models;
using MusicApplication.Models;
using SQLitePCL;
using System.Diagnostics;

namespace MovieModel.Controllers
{
    public class HomeController : Controller
    {
        private MusicContext _context;
        public HomeController(MusicContext moves) {
            _context = moves;
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
            return View();
        }

        [HttpPost]
        public IActionResult Form(Music response)
        {
            _context.MusicForm.Add(response);
            _context.SaveChanges();

            return View("Index");
        }
    }
}
