using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class Seguridad
    {
        public static bool SessionActiva(object user)
        {
            UserLog usuario = user != null ? (UserLog)user : null;

            if (usuario != null && usuario.Id != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool esAdmin(object user)
        {
            UserLog Usuario = user != null ? (UserLog)user : null;

            return user != null ? Usuario.Admin : false;
        }
    }
}
