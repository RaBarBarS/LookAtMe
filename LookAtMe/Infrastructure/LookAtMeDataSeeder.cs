using LookAtMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Infrastructure
{
    public class LookAtMeDataSeeder
    {
        private readonly AppDbContext _dbContext;
        public LookAtMeDataSeeder(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Experiences.Any())
                {
                    var experiences = GetExperiences();
                    _dbContext.Experiences.AddRange(experiences);
                }
                if (!_dbContext.Skills.Any())
                {
                    var skills = GetSkills();
                    _dbContext.Skills.AddRange(skills);
                }
                _dbContext.SaveChanges();
            }
        }
        private IEnumerable<Experience> GetExperiences()
        {
            var experiences = new List<Experience>()
            {
                new Experience()
                {
                    CompanyName = "Testronic Labs",
                    Position = "Quality Assurance Technician",
                    StartDate = new DateTime(2018, 7, 1),
                    EndDate = new DateTime(2018, 9, 30),
                    Responsibilitiese = "Searching and reporting bugs in aplications."
                },
                new Experience()
                {
                    CompanyName = "ideas4biology",
                    Position = "Bioinformatics Analyst - intern",
                    StartDate = new DateTime(2020, 3, 1),
                    EndDate = new DateTime(2020, 4, 30),
                    Responsibilitiese = "Primers design, RNA-seq analisis."
                },
                new Experience()
                {
                    CompanyName = "AVANSSUR",
                    Position = "Intern in automation team",
                    StartDate = new DateTime(2020, 11, 1),
                    EndDate = new DateTime(2021, 6, 30),
                    Responsibilitiese = "Developing automation tests, maintaining testing framework, API testing, programming in .net."
                },
                new Experience()
                {
                    CompanyName = "Intel Technology",
                    Position = "Software Development Intern",
                    StartDate = new DateTime(2021, 7, 1),
                    EndDate = new DateTime(2021, 9, 30),
                    Responsibilitiese = "PyQt5 code refactoring. Maintaining test suite."
                },
                new Experience()
                {
                    CompanyName = "Netcompany",
                    Position = "Consultant",
                    StartDate = new DateTime(2021, 10, 1),
                    EndDate = new DateTime(2021, 10, 29),
                    Responsibilitiese = "Refactoring automated tests written in Java."
                },
                new Experience()
                {
                    CompanyName = "DXC Technology",
                    Position = "Junior .net Developer",
                    StartDate = new DateTime(2021, 11, 1),
                    //EndDate not provided because I'm still working there
                    Responsibilitiese = "Developing apps in .net core."
                }
            };
            return experiences;
        }
        private IEnumerable<Skill> GetSkills()
        {
            var skills = new List<Skill>()
            {
                new Skill()
                {
                    SkillName = ".net programming",
                    SkillLevel = Level.improver,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = ".net mvc",
                    SkillLevel = Level.improver,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = ".net core",
                    SkillLevel = Level.improver,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "entity framework",
                    SkillLevel = Level.improver,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "sql queries",
                    SkillLevel = Level.improver,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "C#",
                    SkillLevel = Level.improver,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "windows forms",
                    SkillLevel = Level.beginner,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "python",
                    SkillLevel = Level.improver,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "pyQT5",
                    SkillLevel = Level.beginner,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "pandas",
                    SkillLevel = Level.beginner,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "R",
                    SkillLevel = Level.beginner,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "linux usage",
                    SkillLevel = Level.improver,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "windows usage",
                    SkillLevel = Level.intermediate,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "jira",
                    SkillLevel = Level.improver,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "git",
                    SkillLevel = Level.improver,
                    Skilltype = SkillType.technical
                },
                new Skill()
                {
                    SkillName = "problem solving",
                    SkillLevel = Level.intermediate,
                    Skilltype = SkillType.soft
                },
                new Skill()
                {
                    SkillName = "teamworking",
                    SkillLevel = Level.intermediate,
                    Skilltype = SkillType.soft
                },
                new Skill()
                {
                    SkillName = "dependability",
                    SkillLevel = Level.advanced,
                    Skilltype = SkillType.soft
                },
                new Skill()
                {
                    SkillName = "critical thinking",
                    SkillLevel = Level.intermediate,
                    Skilltype = SkillType.soft
                },
                new Skill()
                {
                    SkillName = "willingness to learn",
                    SkillLevel = Level.advanced,
                    Skilltype = SkillType.soft
                }
            };
            return skills;
        }
    }
}
