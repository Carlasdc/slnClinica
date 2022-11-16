using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSeguridad
{
    public class AdminSeguridad
    {
        public AdminSeguridad(string usuario, string contrasena)
        {
            Usuario = usuario;
            Contrasena = contrasena;
        }

        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public static bool loginUser(string usuario, string contrasena)
        {
            if(usuario == "PEPE" && contrasena == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
