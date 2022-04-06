using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using LookAtMe.DAL;
using LookAtMe.Models;
using Microsoft.Extensions.Logging.Console;
using AutoMapper;

namespace LookAtMe.Controllers
{
    [ApiController]
    [Route("api/skill")]
    public class SkillController : Controller
    {
        //commented out logger as it is for now not used

        //TODO: properly set up logger

        //private readonly ILogger<SkillController> _logger;
        //public SkillController(ILogger<SkillController> logger, ISkillRepository skillRepository)
        private readonly ISkillRepository _skillRepository;
        private readonly IMapper _mapper;
        public SkillController(ISkillRepository skillRepository, IMapper mapper)
        {
           // _logger = logger; //zamiast console writeline np. _logger.LogInformation('dzialam');
            _skillRepository = skillRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets all skills from database
        /// </summary>
        /// <returns></returns>
        //api/Skill
        [HttpGet]
        public ActionResult<IEnumerable<SkillDto>> GetAll()
        {
            IEnumerable<Models.Skill> skills = _skillRepository.GetSkills();

            if (!skills.Any())
            {
                return NotFound();
            }

            var skillsDtos = _mapper.Map<List<SkillDto>>(skills);

            SkillPage result = new SkillPage();
            result.SkillsList = skills.ToList();

            return View("Index", result);
        }

        /// <summary>
        /// Gets skill by ID 
        /// </summary>
        /// <param name="id">ID of skill to be found</param>
        /// <returns></returns>
        //api/Skill/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Skill>> Get([FromRoute] int id)
        {
            var skill = _skillRepository.GetSkillByID(id);
            if (skill == null)
            {
                return NotFound();
            }

            var skillDto = _mapper.Map<SkillDto>(skill);

            SkillPage result = new SkillPage();
            result.SkillsList = new List<Skill>();
            result.SkillsList.Add(skill);

            return View("Index", result);
        }

        /// <summary>
        /// Creates skill 
        /// </summary>
        /// <param name="dto">informations needed to create a skill</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateSkill([FromBody] CreateSkillDto dto)
        {

            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                var skill = _mapper.Map<Skill>(dto);
                var result = _skillRepository.InsertSkill(skill);

                return Created($"/api/skill/{result.SkillId}", null);
            }
            catch(Exception e)
            {
                //place for logger
            }
            return BadRequest();
        }

        /// <summary>
        /// Deletes skill based on provided ID
        /// </summary>
        /// <param name="id">ID of skill to be deleted</param>
        /// <returns></returns>
        //api/Skill/3
        [HttpDelete("{id}")]
        public ActionResult DeleteSkill([FromRoute] int id)
        {
            var isDeleted = _skillRepository.DeleteSkill(id);

            if (!isDeleted)
            {
                return NotFound();
            }

            return NoContent();
        }

        /// <summary>
        /// Gets all skills that fit filters.
        /// </summary>
        /// <param name="namelike">substring of skill name (case sensitive)</param>
        /// <param name="level">name of the skill leve</param>
        /// <returns></returns>
        //GET: api/Skill/search?namelike=.net&level=1
        [HttpGet("Search")]
        public IActionResult Skill(string namelike = "", int level = -1)//-1 not passed by user
        {
            IEnumerable<Models.Skill> skills;

            if (level != -1)
            {
                skills = _skillRepository.GetSkills()
                        .Where(b => b.SkillName.Contains(namelike) && b.SkillLevel == (Level)level)
                        .OrderBy(b => b.SkillId);
            }
            else
            {
                skills = _skillRepository.GetSkills()
                        .Where(b => b.SkillName.Contains(namelike))
                        .OrderBy(b => b.SkillId);
            }


            if (!skills.Any())
            {
                return NotFound();
            }

            SkillPage result = new SkillPage();
            result.SkillsList = skills.ToList();

            return View("Index", result);
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
