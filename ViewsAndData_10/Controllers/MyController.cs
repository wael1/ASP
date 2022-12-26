using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewsAndData_10.Models;

namespace ViewsAndData_10.Controllers
{
    public class MyController : Controller
    {
        private readonly ILogger<MyController> _logger;

        public MyController(ILogger<MyController> logger)
        {
            _logger = logger;
        }
        [HttpGet()]
        public IActionResult Index1()
        {
            ViewData["Book"] = "the theory of relativity";
            return View();
        }

        [HttpGet()]
        public IActionResult Index2()
        {
            ViewBag.Book = "the theory of relativity";
            return View();
        }

        [HttpGet()]
        public IActionResult Index3()
        {
            return View(new BookViewModel { title = "the theory of relativity", author = "Albert Einstein" });
        }
    }
}
