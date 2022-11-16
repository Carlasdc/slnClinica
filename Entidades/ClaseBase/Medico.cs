using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClaseBase
{
    public class Medico:Persona
    {
        public Medico(int medicoId, string nroMatricula, string nombre, string apellido, string dNI, DateTime fechaNacimiento):base(nombre, apellido, dNI, fechaNacimiento)
        {
            NroMatricula = nroMatricula;
            MedicoId = medicoId;
        }

        public int MedicoId { get; set; }
        public string NroMatricula{ get; set; }
    }
}
