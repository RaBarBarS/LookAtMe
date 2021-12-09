using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using LookAtMe.DAL;
using Microsoft.Extensions.Logging.Console;

namespace LookAtMe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkillController : Controller
    {
        //commented out logger as it is for now not used

        //TODO: properly set up logger

        //private readonly ILogger<SkillController> _logger;
        //public SkillController(ILogger<SkillController> logger, ISkillRepository skillRepository)
        private readonly ISkillRepository _skillRepository;
        public SkillController(ISkillRepository skillRepository)
        {
           // _logger = logger; //zamiast console writeline np. _logger.LogInformation('dzialam');
            _skillRepository = skillRepository;
        }
        //public SkillController()
        //    : this(new SkillRepository(new Models.SkillContext()))
        //{
        //}


        [HttpGet] // /Skill
        public IActionResult Skill()
        {
            {
                //using (var db = new Models.SkillContext())
                //{
                //    Console.WriteLine("Inserting a new skills");
                //    db.Add(new Models.Skill { SkillName = ".net programming", SkillLevel = "junior" });
                //    db.Add(new Models.Skill { SkillName = ".net mvc", SkillLevel = "junior" });
                //    db.Add(new Models.Skill { SkillName = ".net core", SkillLevel = "junior" });
                //    db.Add(new Models.Skill { SkillName = "entity framework", SkillLevel = "junior" });
                //    db.Add(new Models.Skill { SkillName = "sql", SkillLevel = "junior" });
                //    db.Add(new Models.Skill { SkillName = "C#", SkillLevel = "junior/intermediate" });
                //    db.Add(new Models.Skill { SkillName = "windows forms", SkillLevel = "junior/intermediate" });
                //    db.Add(new Models.Skill { SkillName = "algorithms", SkillLevel = "junior/intermediate" });
                //    db.Add(new Models.Skill { SkillName = "python", SkillLevel = "junior" });
                //    db.Add(new Models.Skill { SkillName = "pyQT5", SkillLevel = "junior" });
                //    db.Add(new Models.Skill { SkillName = "pandas", SkillLevel = "junior" });
                //    db.Add(new Models.Skill { SkillName = "R", SkillLevel = "junior" });
                //    db.Add(new Models.Skill { SkillName = "linux", SkillLevel = "intermediate" });
                //    db.Add(new Models.Skill { SkillName = "windows", SkillLevel = "intermediate" });
                //    db.Add(new Models.Skill { SkillName = "jira", SkillLevel = "intermediate" });
                //    db.Add(new Models.Skill { SkillName = "git", SkillLevel = "junior/intermediate" });
                //    db.SaveChanges();

                //    _logger.LogInformation("Querying for a blog");
                //    var skill = db.Skill_db
                //        .OrderBy(b => b.SkillId)
                //        .Last();
                //    _logger.LogInformation('\n' + skill.SkillId.ToString() + '\n');
                //    _logger.LogInformation($"Database path: {db.DbPath}.");
                //}
            }
            
            IEnumerable<Models.Skill> skills = _skillRepository.GetSkills();

            if (!skills.Any())
            {
                return NotFound();
            }
            return Ok(skills);
        }

        //GET: /Skill/search?namelike=.net&level=junior
        [HttpGet("Search")]
        public IActionResult Skill(string namelike = "", string level = "")
        {
            IEnumerable<Models.Skill> result;

            if (level != "")
            {
                result = _skillRepository.GetSkills()
                        .Where(b => b.SkillName.Contains(namelike) && b.SkillLevel == level)
                        .OrderBy(b => b.SkillId);
            }
            else
            {
                result = _skillRepository.GetSkills()
                        .Where(b => b.SkillName.Contains(namelike))
                        .OrderBy(b => b.SkillId);
            }


            if (!result.Any())
            {
                return NotFound();
            }
            return Ok(result);
            //might think about response more like this:
            //return Ok(new
            //{
            //    TotalCount = totalCount,
            //    TotalPages = totalPages,

            //    Orders = orders
            //});
        }
    }
}
