using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace LookAtMe.Models
{
    public class SkillPage : PageModel
    {
        public List<Skill> SkillsList { get; set; }
    }
}
