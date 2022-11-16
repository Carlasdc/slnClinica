using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibSeguridad;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnValidar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
           

            bool validation= AdminSeguridad.loginUser(usuario, contrasena);

            if ( validation == true) 
            {
                MessageBox.Show("Usuario y Contrasena Validados");
            }
            else
            {
                MessageBox.Show("El usuario o la contrasena son incorrectos");
            }
            
        }
    }
}
