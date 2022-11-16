using Entidades.ClasesDerivadas.Adultos;
using Entidades.ClasesDerivadas.Pediatria;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Datos
{
    public class DbMedicosContext:DbContext
    {
        public DbMedicosContext(): base("keyDBMedicos") { }
        public DbSet<Dermatologo> Dermatologos  { get; set; }
        public DbSet<MedicoCardiologo> MedicosCardiologos { get; set; }
        public DbSet<MedicoClinico> MedicosClinicos { get; set; }
        public DbSet<Odontologa> Odontologas { get; set; }
        public DbSet<DermatologoPediatrico> DermatologosPediatricos { get; set; }
        public DbSet<MedicoCardiologoInfantil> MedicosCardiologosInfantiles { get; set; }
        public DbSet<MedicoPediatra> MedicosPediatras { get; set; }
        public DbSet<OdontoPediatra> OdontoPediatras { get; set; }
    }
}
