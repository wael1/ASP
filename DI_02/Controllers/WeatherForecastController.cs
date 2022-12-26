using DI_02.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        //private readonly ILogger<WeatherForecastController> _logger;
        private readonly IEnumerable<IHello> _HelloServices;

        public WeatherForecastController(IEnumerable<IHello> HelloServices)
        {
           // _logger = logger;
            _HelloServices= HelloServices;
        }
       
        [HttpGet]
        public IActionResult Get()
        {
            string Hello = "";
            foreach (var weatherService in _HelloServices)
            {
                Hello += weatherService.GetHello();
            }

            return Ok(Hello);
        }
    }
}
