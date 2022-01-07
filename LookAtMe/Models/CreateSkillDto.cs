using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Models
{
    public class CreateSkillDto: IValidatableObject
    {
        public string SkillName { get; set; }
        public string SkillLevel { get; set; }
        public string Skilltype { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(!Enum.TryParse(SkillLevel, true, out Level levelResult))
            {
                yield return new ValidationResult("Invalid SkillLevel type", new[] { nameof(Level) });
            }
            SkillLevel = levelResult.ToString();

            if (!Enum.TryParse(Skilltype, true, out SkillType typeResult))
            {
                yield return new ValidationResult("Invalid SkillType type", new[] { nameof(SkillType) });
            }
            SkillLevel = typeResult.ToString();
        }
    }
}
