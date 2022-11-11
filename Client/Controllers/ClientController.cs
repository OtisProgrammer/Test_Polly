using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        //https://carlpaton.github.io/2021/12/http-retry-polly/
        private readonly IHttpHelperService _httpHelperService;
        private readonly ILogger<ClientController> _logger;
        public ClientController(ILogger<ClientController> logger, IHttpHelperService httpHelperService)
        {
            _logger = logger;
            _httpHelperService = httpHelperService;
        }
        [HttpGet("Get/{name}")]
        public async Task<IActionResult> Get(string name)
        {
            return Ok(await _httpHelperService.Post(name));
        }
    }
}
