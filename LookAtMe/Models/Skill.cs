using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
        [JsonConverter(typeof(StringEnumConverter))]
        public Level SkillLevel { get; set; }
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public SkillType Skilltype { get; set; }
    }
}
