using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using LookAtMe.Models;
using LookAtMe.Services;

namespace LookAtMe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Plant>> GetAll() => PlantService.GetAll();

        [HttpGet("{name}")]
        public ActionResult<Plant> Get(string name)
        {
            var plant = PlantService.Get(name);

            if (plant == null)
                return NotFound();

            return plant;
        }

        [HttpPost]
        public IActionResult Create(Plant plant)
        {
            PlantService.Add(plant);
            return CreatedAtAction(nameof(Create), new { name = plant.Name }, plant);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string name, Plant plant)
        {
            if (name != plant.Name)
                return BadRequest();

            var existingPizza = PlantService.Get(name);
            if (existingPizza is null)
                return NotFound();

            PlantService.Update(plant);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string name)
        {
            var plant = PlantService.Get(name);

            if (plant is null)
                return NotFound();

            PlantService.Delete(name);

            return NoContent();
        }
    }
}
