using Entidades.ClaseBase;
using Entidades.ClasesDerivadas.Pediatria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppClinica
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            MedicoPediatra mepediatra = new MedicoPediatra(125,"45102", "Mario", "Lopez", "18002046", new DateTime(1987, 12, 07), 4580);
            
            MessageBox.Show($"Nombre del Medico: {mepediatra.Nombre},{mepediatra.Apellido}," +
                $" Numero de matricula: {mepediatra.NroMatricula} y DNI: {mepediatra.DNI}. " +
                $"Su fecha de nacimiento es: {mepediatra.FechaNacimiento}");
        }
    }
}
