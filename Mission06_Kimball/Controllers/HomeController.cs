using System.Diagnostics;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Mission06_Kimball.Models;

namespace Mission06_Kimball.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext temp) // Constructor
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GettoKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            _context.Movies.Add(response); // Add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
