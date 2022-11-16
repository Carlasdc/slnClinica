using Entidades.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades.ClasesDerivadas.Adultos
{
    public class MedicoCardiologo : Medico
    {
        public MedicoCardiologo(int medicoId, string nroMatricula, string nombre, string apellido, string dNI, DateTime fechaNacimiento, int medicoCardiologoId) : base(medicoId, nroMatricula, nombre, apellido, dNI, fechaNacimiento)
        {
            MedicoCardiologoId = medicoCardiologoId;
        }
        public int MedicoCardiologoId { get; set; }
    }
}
