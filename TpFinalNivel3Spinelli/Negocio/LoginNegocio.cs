using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class LoginNegocio
    {
        public void registrar(UserLog user)
        {
            try
            {
                AccesoADatos datos = new AccesoADatos();
                datos.establecerConsulta("INSERT INTO USERS (email, pass) VALUES (@Email, @Pass)");
                datos.setearparametros("@Email", user.Email);
                datos.setearparametros("@Pass", user.Contraseña);
                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public UserLog ingresar(UserLog Usuario)
        {
            AccesoADatos datos = new AccesoADatos();
            UserLog user = new UserLog();
            try
            {


                datos.establecerConsulta("SELECT id,email,pass,nombre,apellido,urlImagenPerfil,admin FROM USERS WHERE email=@email and pass=@pass");
                datos.setearparametros("@email", Usuario.Email);
                datos.setearparametros("@pass", Usuario.Contraseña);
                datos.establecerlectura();


                if (datos.Lector.Read())
                {
                    user.Id = (int)datos.Lector["id"];
                    user.Email = (string)datos.Lector["email"];
                    user.Contraseña = (string)datos.Lector["pass"];

                    if (!(DBNull.Value.Equals(datos.Lector["nombre"])))
                    {
                        user.Nombre = (string)datos.Lector["nombre"];
                    }

                    if (!(DBNull.Value.Equals(datos.Lector["apellido"])))
                    {
                        user.Apellido = (string)datos.Lector["apellido"];
                    }


                    if (!(DBNull.Value.Equals(datos.Lector["urlImagenPerfil"])))
                    {
                        user.UrlImagenPerfil = (string)datos.Lector["urlImagenPerfil"];
                    }
                    user.Admin = (bool)datos.Lector["admin"];

                }

                
                return user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }

        }

        public void Modificar(UserLog usuario)
        {
            try
            {
                AccesoADatos datos = new AccesoADatos();
                datos.establecerConsulta("update USERS set nombre=@nombre,apellido=@apellido,urlImagenPerfil=@url where id=@id");

                datos.setearparametros("@nombre", usuario.Nombre ?? (object)DBNull.Value);
                datos.setearparametros("@apellido", usuario.Apellido ?? (object)DBNull.Value);
                datos.setearparametros("@url", usuario.UrlImagenPerfil ?? (object)DBNull.Value);
                datos.setearparametros("@id", usuario.Id);

                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
