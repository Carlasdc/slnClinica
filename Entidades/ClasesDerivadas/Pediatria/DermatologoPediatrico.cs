using Entidades.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesDerivadas.Pediatria
{
    public class DermatologoPediatrico : Medico
    {
        public DermatologoPediatrico(int medicoId, string nroMatricula, string nombre, string apellido, string dNI, DateTime fechaNacimiento, int dermatologoPediatricoId) : base(medicoId, nroMatricula, nombre, apellido, dNI, fechaNacimiento)
        {
            DermatologoPediatricoId = dermatologoPediatricoId;
        }
        public int DermatologoPediatricoId { get; set; }
    }
}
