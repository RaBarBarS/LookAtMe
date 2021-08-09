using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using LookAtMe.Models;

namespace LookAtMe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantsController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
            "Ginger", "Money tree", "Sun flowers"
        };

        private static readonly string[] Heights = new[]
        {
            "small", "medium", "big"
        };

        private static readonly string[] Summaries = new[]
        {
            "Nice leaves", "Beautiful", "Easy care"
        };

        private readonly ILogger<PlantsController> _logger;

        public PlantsController(ILogger<PlantsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Plant> Get()
        {
            var rng = new Random();
            return Enumerable.Range(0, Names.Length).Select(index => new Plant
            {
                Name = Names[index],
                Height = Heights[index],
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
