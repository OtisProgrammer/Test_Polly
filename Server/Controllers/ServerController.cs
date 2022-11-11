using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServerController : ControllerBase
    {

        [HttpPost("Post")]
        public IActionResult Post([FromBody] RequestDto request)
        {
            if (request.Name=="ali")
                return NotFound();
            
            return Ok(new {result = "Hello " + request.Name});
        }
    }

    public class RequestDto
    {
        public string Name { get; set; }
    }
}
