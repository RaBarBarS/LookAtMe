using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Models;

namespace LookAtMe.DAL
{
    public interface ISkillRepository : IDisposable
    {
        IEnumerable<Skill> GetSkills();
        Skill GetSkillByID(int skillId);
        Skill InsertSkill(Skill skill);
        void DeleteSkill(int skillId);
        void UpdateSkill(Skill skill);
        void Save();
    }
}
