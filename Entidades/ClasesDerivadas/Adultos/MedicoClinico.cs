using Entidades.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesDerivadas.Adultos
{
    public class MedicoClinico : Medico
    {
        public MedicoClinico(int medicoId, string nroMatricula, string nombre, string apellido, string dNI, DateTime fechaNacimiento, int medicoClinicoId) : base(medicoId, nroMatricula, nombre, apellido, dNI, fechaNacimiento)
        {
            MedicoClinicoId = medicoClinicoId;
        }
        public int MedicoClinicoId { get; set; }
    }
}
