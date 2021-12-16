using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Models
{
    public enum Level { beginner, improver, intermediate, advanced};
    public enum SkillType { technical, soft}
    public class Skill
    {
        public int SkillId { get; set; }
        [Required]
        public string SkillName { get; set; }
        [Required]
        public Level SkillLevel { get; set; }
        [Required]
        public SkillType Skilltype { get; set; }
    }
}
