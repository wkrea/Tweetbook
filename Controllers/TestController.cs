using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Tweetbook.Controllers
{
    public class TestController : Controller
    {
        public TestController()
        {
            //List<string> Posts = new List<string>();

            //foreach(var i )
            //{

            //}
        }

        [HttpGet("api/user")]
        public IActionResult Get()
        {
            return Ok(new { Name = "Nick" });
        }
    }
}
