using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        [Required]
        public string SkillName { get; set; }
        [Required]
        public string SkillLevel { get; set; }
    }
}
