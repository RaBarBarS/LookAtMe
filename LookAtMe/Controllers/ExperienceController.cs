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
    public class ExperienceController : Controller
    {
        //GET: /Privacy
        public IActionResult Index()
        {
            return View();
        }
    }
}
