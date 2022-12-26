using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TagHelpers_11.Models;

namespace TagHelpers_11.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index1()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie() { Id = 1, Title = "The Godfather" },
                new Movie() { Id = 2, Title = "Forrest Gump" },
                new Movie() { Id = 3, Title = "Fight Club" },
            };
            return View(movies);
        }
        public IActionResult Index2()
        {
            return View();
        }

        
        [HttpPost]
        public string Submit(BookViewModel model)
        {
            return model.title;
        }

    }
}
