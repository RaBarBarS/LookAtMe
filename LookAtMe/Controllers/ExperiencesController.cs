using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Models;
using Microsoft.Extensions.Logging;

namespace LookAtMe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExperiencesController : Controller
    {
        [HttpGet] // /Experiences
        public IActionResult Experiences()
        {
            //if (!experiences.Any())
            //{
            //    return NotFound();
            //}
            return Ok();
        }

        private readonly ILogger<ExperiencesController> _logger;

        public ExperiencesController(ILogger<ExperiencesController> logger)
        {
            _logger = logger; //zamiast console writeline np. _logger.LogInformation('dzialam');
        }
    }
}
