using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace HelloWorld.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello nigga!");
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] JObject payLoad)
        {
            return Ok(payLoad);
        }
    }
}