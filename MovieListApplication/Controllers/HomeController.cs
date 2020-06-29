using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieListApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieListApplication.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext Context{ get; set; }

        public HomeController(MovieContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            var movies = Context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }

}
