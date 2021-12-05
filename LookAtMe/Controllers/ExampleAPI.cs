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
    }
}
