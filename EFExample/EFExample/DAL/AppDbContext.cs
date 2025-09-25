using EFExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=msi;database=EFPB306;trusted_connection=true;integrated security=true;encrypt=false;");
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}
