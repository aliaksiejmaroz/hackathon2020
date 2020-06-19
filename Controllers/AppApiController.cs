using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using hackathon2020.Models;

namespace hackathon2020.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppApiController : ControllerBase
    {
        private readonly ILogger<AppApiController> _logger;

        public AppApiController(ILogger<AppApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/env")]
        public MagicEnvironment Get()
        {
            var env = new MagicEnvironment();
            env.AppSecret = Guid.NewGuid();
            env.AppId = "MagicApp";
            return env;
        }
    }
}