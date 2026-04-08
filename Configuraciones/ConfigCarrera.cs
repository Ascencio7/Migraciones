using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trans.Models;

namespace Trans.Configuraciones
{
    public class ConfigCarrera
    {
        public ConfigCarrera(EntityTypeBuilder<Carrera> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Jornada).HasMaxLength(100);

            builder.HasCheckConstraint("CK_Carrera_CantMaterias", "CantMaterias <= 20");

        }
    }
}