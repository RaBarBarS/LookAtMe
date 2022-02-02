using System;
using System.Collections.Generic;
using System.Linq;
using LookAtMe.Infrastructure;
using LookAtMe.Models;

namespace LookAtMe.DAL
{
    public class SkillRepository : ISkillRepository, IDisposable
    {
        private readonly AppDbContext context;
        public SkillRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Skill> GetSkills()
        {
            return context.Skills.ToList();
        }

        public Skill GetSkillByID(int skillId)
        {
            return context.Skills.FirstOrDefault(s => s.SkillId == skillId);
        }

        public Skill InsertSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return skill;
        }

        public bool DeleteSkill(int skillId)
        {
            Skill skill = context
                            .Skills
                            .FirstOrDefault(s => s.SkillId == skillId);

            if (skill == null)
            {
                return false;
            }

            context.Skills.Remove(skill);
            context.SaveChanges();
            return true;
        }

        public void UpdateSkill(Skill skill)
        {
            context.Entry(skill).State = Microsoft.EntityFrameworkCore.EntityState.Modified; //Może być błąd, sprawdzic czy działa jak powinno!
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
