using FormationCV.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCV.Data
{
    public class Context : DbContext
    {
        public DbSet<CV> CVs { get; set; }
        public DbSet<Langue> Langues { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<Competence> Competences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CV;Integrated Security=true");
        }

    }
}
