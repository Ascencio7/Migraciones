using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Trans.Configuraciones;

namespace Trans.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Carrera> Carreras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=VLADIMIR\\ASCENCIO;Database=TRANSACCIONES;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new ConfigPersonas(builder.Entity<Persona>());
            new ConfigCarrera(builder.Entity<Carrera>());
        }

    }
}