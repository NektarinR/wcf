

using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;

namespace testConsole
{
    public class SqliteContext : DbContext
    {
        public DbSet<FileModel> Files { get; set; }
        public DbSet<LogModel> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            var path = ConfigurationManager.ConnectionStrings["SqliteConnection"].ConnectionString;
            optionsBuilder.UseSqlite(String.Format(path));//, Directory.GetCurrentDirectory()));
        }
    }
}
