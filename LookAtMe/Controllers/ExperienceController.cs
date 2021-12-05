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
            using (var db = new Models.ExperienceContext())
            {
                //Console.WriteLine("Inserting a new blog");
                //db.Add(new Experience { CompanyName = "Testronic Labs", Duration = "07.2018 - 09.2018", Position = "Manual Tester", Responsibilitiese = "manual testing, reporting bugs" });
                //db.Add(new Experience { CompanyName = "Ideas4biology", Duration = "03.2020 - 09.2020", Position = "Bioinformatician Analyst Intern", Responsibilitiese = "primers design, RNA-seq analisis" });
                //db.Add(new Experience { CompanyName = "AXA Avanssur", Duration = "11.2020 - 06.2021", Position = "Automation Intern", Responsibilitiese = "developing automation tests, maintaining testing framework, API testing, programming in C#" });
                //db.Add(new Experience { CompanyName = "Intel", Duration = "07.2021 - 09.2021", Position = "Software Development Intern", Responsibilitiese = "PyQt5 code refactoring, maintaining test suite" });
                //db.Add(new Experience { CompanyName = "Netcompany", Duration = "10.2021 - 10.2021", Position = "Consultant", Responsibilitiese = "test suite refactoring" });
                //db.Add(new Experience { CompanyName = "DXC Technology", Duration = "11.2021 - now", Position = "Junior .net Developer", Responsibilitiese = "programming in .net" });
                //db.Add(new Experience { CompanyName = "YOUR COMPANY", Duration = "TOMORROW?", Position = "JUNIOR .NET DEVELOPER", Responsibilitiese = "MAKING YOUR PROJECT GREAT" });
                //db.SaveChanges();

                //_logger.LogInformation("Querying for a blog");
                //var blog = db.Exp_db
                //    .OrderBy(b => b.ExperienceId)
                //    .Last();
                //_logger.LogInformation('\n' + blog.ExperienceId.ToString() + '\n');
                //_logger.LogInformation($"Database path: {db.DbPath}.");
            }
            return View();
        }
    }
}
