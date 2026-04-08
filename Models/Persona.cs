using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trans.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Salario { get; set; }
        public int deptoId { get; set; }
        public Departamento depto { get; set; }
    }

    public class Departamento
    {
        public int Id { get; set; }
        public string NombreDepto { get; set; }
        public int CantidadEmpleados { get; set; }
        public ICollection<Carrera> Carreras { get; set; }
    }

    public class Carrera
    {
        public int Id { get; set;  }
        public string Nombre { get; set; }
        public string Jornada { get; set; }
        public int CantMaterias { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento departamento { get; set; }
    }
}