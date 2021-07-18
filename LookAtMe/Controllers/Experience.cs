using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Controllers
{
    public class Experience : Controller
    {
        //GET: /Privacy
        public IActionResult Index()
        {
            return View();
        }
    }
}
