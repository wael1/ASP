using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ViewsInMVC_09.Controllers
{
    public class TestController: Controller
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
