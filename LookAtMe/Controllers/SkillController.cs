using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using LookAtMe.DAL;
using LookAtMe.Models;
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
            IEnumerable<Models.Skill> skills = _skillRepository.GetSkills();

            if (!skills.Any())
            {
                return NotFound();
            }
            return Ok(skills);
        }

        //GET: /Skill/search?namelike=.net&level=junior
        [HttpGet("Search")]
        public IActionResult Skill(string namelike = "", int level = -1)//-1 not passed by user
        {
            IEnumerable<Models.Skill> result;

            if (level != -1)
            {
                result = _skillRepository.GetSkills()
                        .Where(b => b.SkillName.Contains(namelike) && b.SkillLevel == (Level)level)
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
