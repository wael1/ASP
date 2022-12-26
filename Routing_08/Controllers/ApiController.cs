using Microsoft.AspNetCore.Mvc;

namespace Routing_08.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet("firstindex")]
        public string FIndex()
        {
            return "First index!";
        }


        [Route("secondindex")]
        public string SIndex()
        {
            return "Second Index!";
        }


        [Route("/thirdindex")]
        public string TIndex()
        {
            return "Third Index!";
        }
    }
}
