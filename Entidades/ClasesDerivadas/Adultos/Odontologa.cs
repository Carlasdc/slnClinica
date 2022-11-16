using Entidades.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesDerivadas.Adultos
{
    public class Odontologa : Medico
    {
        public Odontologa(int medicoId, string nroMatricula, string nombre, string apellido, string dNI, DateTime fechaNacimiento, int odontologaId) : base(medicoId, nroMatricula, nombre, apellido, dNI, fechaNacimiento)
        {
            OdontologaId = odontologaId;
        }
        public int OdontologaId { get; set; }
    }
}
