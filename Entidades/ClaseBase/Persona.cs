using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClaseBase
{
    public class Persona
    {
        public Persona(string nombre, string apellido, string dNI, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            FechaNacimiento = fechaNacimiento;
        }
        public Persona() { }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
