using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Controllers
{
    public class AboutMe : Controller
    {
        ////GET: /AboutMe
        //public string Index()
        //{
        //    return "This app will be my portfolio.\nI'm at beggining of my programming journey. Wish me luck!";
        //}

        //GET: /AboutMe
        public IActionResult Index()
        {
            return View();
        }
    }
}
