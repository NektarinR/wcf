using ConsoleApp1.Models;
using ConsoleApp1.Models.Agreement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;

namespace testConsole
{
    public class SqliteContext : DbContext
    {
        public DbSet<FileModel> Files { get; set; }
        public DbSet<LogModel> Logs { get; set; }
        public DbSet<Shared> Agreements { get; set; }
        public DbSet<AgreementOrg> AgreementOrgs { get; set; }
        public DbSet<Bo> Bos { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = ConfigurationManager.ConnectionStrings["SqliteConnection"].ConnectionString;
            optionsBuilder.UseSqlite(String.Format(path));//, Directory.GetCurrentDirectory()));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agreement>().HasBaseType<Shared>();
        }
    }
}