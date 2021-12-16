using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Models
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } //not required since person can still work there
        [Required]
        [StringLength(200)]
        public string Responsibilitiese { get; set; }
    }
}
