using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LookAtMe.Models;

namespace LookAtMe.Infrastructure
{
    public class AppDbContext : DbContext
    {
        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=LookAtMeAppDb;Trusted_Connection=True;";
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) :
            base(dbContextOptions)
        {
        }
    }
}
