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
        private string _connectionString = @"Server=.\SQLEXPRESS;Database=AppDb;Trusted_Connection=True;";
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) :
            base(dbContextOptions)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Skill>()
        //        .Property(s => s.SkillName)
        //        .IsRequired();

        //    modelBuilder.Entity<Experience>()
        //        .Property(e => e.CompanyName)
        //        .IsRequired();
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_connectionString);
        //}
    }
}
