using Entidades.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesDerivadas.Pediatria
{
    public class MedicoCardiologoInfantil : Medico
    {
        public MedicoCardiologoInfantil(int medicoCardioInfantilId, int medicoId, string nroMatricula, string nombre, string apellido, string dNI, DateTime fechaNacimiento) : base(medicoId, nroMatricula, nombre, apellido, dNI, fechaNacimiento)
        {
            MedicoCardioInfantilId = medicoCardioInfantilId;
        }
        public int MedicoCardioInfantilId{ get; set; }
    }
}
