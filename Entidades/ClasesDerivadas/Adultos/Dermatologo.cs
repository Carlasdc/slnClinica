using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ClaseBase;

namespace Entidades.ClasesDerivadas.Adultos
{
    public class Dermatologo : Medico
    {
        public Dermatologo(int medicoId, string nroMatricula, string nombre, string apellido, string dNI, DateTime fechaNacimiento, int dermatologoId) : base( medicoId, nroMatricula, nombre, apellido, dNI, fechaNacimiento)
        {
            DermatologoId = dermatologoId;
        }
        public int DermatologoId { get; set; }
    }
}
