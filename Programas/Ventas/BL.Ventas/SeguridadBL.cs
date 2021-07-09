using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class SeguridadBL
    {

        public bool Autorizar(string usuario, string contrasena)
        {
            if (usuario == "admin" && contrasena == "tienda")
            {
                return true;
            }
            else if (usuario == "tienda" && contrasena == "caja")
            {
                return true;
            }
            
            return false;
        }
    }
}
