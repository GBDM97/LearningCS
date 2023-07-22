using Microsoft.AspNetCore.Mvc;
using LearningCS.ApplicationContext;

namespace LearningCS.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class MyFirstProgram : ControllerBase
    {   
        private readonly MyContext ctx;
        [HttpGet]
        public IActionResult Get()
        {
            // Implement your logic to fetch and return data here.
            return Ok(ctx.Books);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            // Implement your logic to process the incoming data here.
            return Ok($"API Controller POST method - Received value: {value}");
        }
    }
}
