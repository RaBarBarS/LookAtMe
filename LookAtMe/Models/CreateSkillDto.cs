using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Models
{
    public class CreateSkillDto
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public Level SkillLevel { get; set; }
        public SkillType Skilltype { get; set; }
    }
}
