using Entidades.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermero:Persona
    {
        public Enfermero(string nombre, string apellido, string dNI, DateTime fechaNacimiento):base(nombre, apellido, dNI, fechaNacimiento)
        {

        }
    }
}
