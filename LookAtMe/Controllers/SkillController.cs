﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace LookAtMe.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new Models.SkillContext())
            {
                //Console.WriteLine("Inserting a new skills");
                //db.Add(new Models.Skill { SkillName = ".net programming", SkillLevel = "junior" });
                //db.Add(new Models.Skill { SkillName = ".net mvc", SkillLevel = "junior" });
                //db.Add(new Models.Skill { SkillName = ".net core", SkillLevel = "junior" });
                //db.Add(new Models.Skill { SkillName = "entity framework", SkillLevel = "junior" });
                //db.Add(new Models.Skill { SkillName = "sql", SkillLevel = "junior" });
                //db.Add(new Models.Skill { SkillName = "C#", SkillLevel = "junior/intermediate" });
                //db.Add(new Models.Skill { SkillName = "windows forms", SkillLevel = "junior/intermediate" });
                //db.Add(new Models.Skill { SkillName = "algorithms", SkillLevel = "junior/intermediate" });
                //db.Add(new Models.Skill { SkillName = "python", SkillLevel = "junior" });
                //db.Add(new Models.Skill { SkillName = "pyQT5", SkillLevel = "junior" });
                //db.Add(new Models.Skill { SkillName = "pandas", SkillLevel = "junior" });
                //db.Add(new Models.Skill { SkillName = "R", SkillLevel = "junior" });
                //db.Add(new Models.Skill { SkillName = "linux", SkillLevel = "intermediate" });
                //db.Add(new Models.Skill { SkillName = "windows", SkillLevel = "intermediate" });
                //db.Add(new Models.Skill { SkillName = "jira", SkillLevel = "intermediate" });
                //db.Add(new Models.Skill { SkillName = "git", SkillLevel = "junior/intermediate" });
                //db.SaveChanges();

                //_logger.LogInformation("Querying for a blog");
                //var skill = db.Skill_db
                //    .OrderBy(b => b.SkillId)
                //    .Last();
                //_logger.LogInformation('\n' + skill.SkillId.ToString() + '\n');
                //_logger.LogInformation($"Database path: {db.DbPath}.");
            }
            return View();
        }

        private readonly ILogger<SkillController> _logger;

        public SkillController(ILogger<SkillController> logger)
        {
            _logger = logger; //zamiast console writeline np. _logger.LogInformation('dzialam');
        }
    }
}
