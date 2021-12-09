using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return context.Skills.Find(skillId);//TODO: search by level and name NOT id!
        }

        public void InsertSkill(Skill skill)
        {
            context.Skills.Add(skill);
        }

        public void DeleteSkill(int skillId)
        {
            Skill skill = context.Skills.Find(skillId);//TODO: do deleting by id will be ok?
            context.Skills.Remove(skill);
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
