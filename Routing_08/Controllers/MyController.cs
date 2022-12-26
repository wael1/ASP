using Microsoft.Extensions.Logging;

namespace Routing_08.Controllers
{
    public class MyController
    {
        private readonly ILogger<MyController> _logger;

        public MyController(ILogger<MyController> logger)
        {
            _logger = logger;
        }

        public string Action()
        {
            return "Hello world!";
        }
        
    }
}
