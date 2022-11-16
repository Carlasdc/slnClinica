using Entidades.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesDerivadas.Pediatria
{
    public class OdontoPediatra : Medico
    {
        public OdontoPediatra(int medicoId, string nroMatricula, string nombre, string apellido, string dNI, DateTime fechaNacimiento, int odontoPediatraId) : base(medicoId, nroMatricula, nombre, apellido, dNI, fechaNacimiento)
        {
            OdontoPediatraId = odontoPediatraId;
        }
        public int OdontoPediatraId { get; set; }
    }
}
