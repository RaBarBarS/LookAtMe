using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Controllers
{
    public class ExampleAPI : Controller
    {
        //GET: /ExampleAPI
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] ///ExampleAPI/GetExp
        public IActionResult GetExp()
        {
            var db = new Models.ExperienceContext();
            IOrderedQueryable<Models.Experience> experiences = db.Exp_db
                                .OrderByDescending(b => b.ExperienceId);
            return Ok(experiences);
        }
    }
}
