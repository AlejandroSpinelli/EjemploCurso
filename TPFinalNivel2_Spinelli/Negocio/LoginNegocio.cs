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
                datos.establecerConsulta("INSERT INTO USERS (email, pass, nombre, apellido, urlImagenPerfil, admin) VALUES (@Email, @Pass, @Nombre, @Apellido, @Url, @Admin)");


                datos.setearparametros("@Email", user.Email);
                datos.setearparametros("@Pass", user.Contraseña);
                datos.setearparametros("@Nombre", user.Nombre);
                datos.setearparametros("@Apellido", user.Apellido);
                datos.setearparametros("@Url", user.UrlImagenPerfil);
                datos.setearparametros("@Admin", user.Admin);

                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public bool verificarmail(string mail)
        {
            try
            {
                UserLog usu = new UserLog();
                AccesoADatos datos = new AccesoADatos();
                datos.establecerConsulta("SELECT email FROM USERS WHERE email = '" + mail + "'");
                datos.establecerlectura();

                if (datos.Lector.Read())
                {
                    usu.Email = (string)datos.Lector["email"];
                    datos.cerrarconexion();
                    return true;
                }
                datos.cerrarconexion();
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public UserLog ingresar(string usuario, string contraseña)
        {
            AccesoADatos datos = new AccesoADatos();
            UserLog user = new UserLog();

            datos.establecerConsulta("SELECT id,email,pass,nombre,apellido,urlImagenPerfil,admin FROM USERS WHERE email='" + usuario + "' and pass='" + contraseña + "'");

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

            datos.cerrarconexion();
            return user;
        }

        public UserLog traerimagen(string usuario)
        {
            AccesoADatos datos = new AccesoADatos();
            UserLog user = new UserLog();

            datos.establecerConsulta("SELECT email,pass,urlImagenPerfil FROM USERS WHERE email='" + usuario + "'");

            datos.establecerlectura();


            if (datos.Lector.Read())
            {

                user.Email = (string)datos.Lector["email"];
                user.Contraseña = (string)datos.Lector["pass"];
                if (!(DBNull.Value.Equals(datos.Lector["urlImagenPerfil"])))
                {
                    user.UrlImagenPerfil = (string)datos.Lector["urlImagenPerfil"];
                }


            }

            datos.cerrarconexion();
            return user;
        }

        public void Modificar(UserLog usuario, string Nombre, string Apellido, string Url)
        {
            AccesoADatos datos = new AccesoADatos();
            datos.establecerConsulta("update USERS set nombre=@nombre,apellido=@apellido,urlImagenPerfil=@url where id=@id");

            datos.setearparametros("@nombre", Nombre);
            datos.setearparametros("@apellido", Apellido);
            datos.setearparametros("@url", Url);
            datos.setearparametros("@id", usuario.Id);

            datos.ejecutaraccion();

        }

        public UserLog Actualizar(UserLog usuario)
        {
            try
            {
                UserLog usu = new UserLog();
                AccesoADatos datos = new AccesoADatos();
                datos.establecerConsulta("SELECT nombre,apellido,urlImagenPerfil FROM USERS WHERE email = '" + usuario.Email + "'");

                datos.establecerlectura();

                if (datos.Lector.Read())
                {
                    if (!(DBNull.Value.Equals(datos.Lector["nombre"])))
                    {
                        usu.Nombre = (string)datos.Lector["nombre"];
                    }

                    if (!(DBNull.Value.Equals(datos.Lector["apellido"])))
                    {
                        usu.Apellido = (string)datos.Lector["apellido"];
                    }

                    if (!(DBNull.Value.Equals(datos.Lector["urlImagenPerfil"])))
                    {
                        usu.UrlImagenPerfil = (string)datos.Lector["urlImagenPerfil"];
                    }

                    
                    datos.cerrarconexion();
                    
                }
                datos.cerrarconexion();
                return usu;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CambiarContraseña(UserLog usuario, string pass)
        {
           
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.establecerConsulta("update USERS set pass='" + pass + "' where id='" + usuario.Id + "'");
                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public bool VerificarPass(UserLog usuario,string pass)
        {
            UserLog aux = new UserLog();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.establecerConsulta("select pass from USERS where id='" + usuario.Id + "'");
                datos.establecerlectura();

                if (datos.Lector.Read())
                {
                    aux.Contraseña = (string)datos.Lector["pass"];
                }

                if (aux.Contraseña == pass)
                {
                    
                    return true;
                }
                
                return false;
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

        public bool VerificarPassAdmin(string pass)
        {
            AccesoADatos datos=new AccesoADatos();
            datos.establecerConsulta("select pass from USERS where email='admin@admin.com'");
            datos.establecerlectura();
            UserLog aux = new UserLog();
            if (datos.Lector.Read())
            {   
                aux.Contraseña = (string)datos.Lector["pass"];
            }
            datos.cerrarconexion();

            if (aux.Contraseña == pass)
            {
                return true;
            }
            
            return false;
        }
    }
}
