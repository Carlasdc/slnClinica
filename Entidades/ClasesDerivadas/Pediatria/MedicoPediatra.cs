﻿using Entidades.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesDerivadas.Pediatria
{
    public class MedicoPediatra : Medico
    {
        public MedicoPediatra(int medicoId, string nroMatricula, string nombre, string apellido, string dNI, DateTime fechaNacimiento, int medicoPediatraId) : base(medicoId, nroMatricula, nombre, apellido, dNI, fechaNacimiento)
        {
            MedicoPediatraId = medicoPediatraId;
        }
        public int MedicoPediatraId { get; set; }
    }
}
