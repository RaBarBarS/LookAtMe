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
    }
}
