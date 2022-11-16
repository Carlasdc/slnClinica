using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClaseBase
{
    internal class Especialidad:Medico
    {
        public Especialidad(string especilidadMedico, int medicoId, string nroMatricula, string nombre, string apellido, string dNI, DateTime fechaNacimiento) :base(medicoId,nroMatricula, nombre, apellido, dNI, fechaNacimiento)
        {
            EspecialidadMedico = especilidadMedico;
        }
        
        public string EspecialidadMedico { get; set; }
    }
}
