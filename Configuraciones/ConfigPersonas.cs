using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trans.Models;

namespace Trans.Configuraciones
{
    public class ConfigPersonas
    {
        public ConfigPersonas(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Apellido).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Salario).HasPrecision(18, 2);
        }
    }
}