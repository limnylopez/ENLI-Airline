using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class SeguridadBL
    {
       public bool Autorizar(string usuario, string contrasena) //necesita recibir un usuario y una contraseña
        {
            if (usuario == "Limny" && contrasena == "123")
            {
                return true;
            } 
            else
            {
                    if (usuario == "Enia" && contrasena == "321")
                {
                    return true;
                }              
            }
            return false;
        }
    }
}
