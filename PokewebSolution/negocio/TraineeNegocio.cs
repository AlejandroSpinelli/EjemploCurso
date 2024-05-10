using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace negocio
{
    public class TraineeNegocio
    {
        public int insetarnuevo(Trainee nuevo)
		{   
            AccesoDatos datos = new AccesoDatos();

			try
			{
                datos.SetearProcedimiento("insertarnuevo");
                datos.setearParametro("@email", nuevo.mail);
                datos.setearParametro("@pass", nuevo.pass);
                return datos.ejecutarAccionScalar();
                
            }
			catch (Exception ex)
			{

				throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }

        public bool Login(Trainee trainee)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("select id,email,pass,admin,imagenPerfil,fechaNacimiento,nombre,apellido from USERS where email=@mail and pass=@pass");
                datos.setearParametro("@mail", trainee.mail);
                datos.setearParametro("@pass", trainee.pass);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    trainee.id = (int)datos.Lector["id"];
                    trainee.admin = (bool)datos.Lector["admin"];

                    if (!(datos.Lector["nombre"] is DBNull))
                    {
                        trainee.nombre = (string)datos.Lector["nombre"];
                    }
                    if (!(datos.Lector["apellido"] is DBNull))
                    {
                        trainee.apellido = (string)datos.Lector["apellido"];
                    }
                        
                    if (!(datos.Lector["email"] is DBNull))
                    {
                        trainee.mail = (string)datos.Lector["email"];
                      
                    }

                    if (!(datos.Lector["imagenPerfil"] is DBNull)){
                        trainee.urlImagen = (string)datos.Lector["imagenPerfil"];
                    }

                    if (!(datos.Lector["fechaNAcimiento"] is DBNull))
                    {
                        trainee.fechaNacimiento = DateTime.Parse(datos.Lector["fechaNacimiento"].ToString());

                    }
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }

        public void actualizar(Trainee user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.setearConsulta("update Users set imagenPerfil=@imagen,fechaNacimiento=@fecha,nombre=@nombre,apellido=@apellido where id=@id");
                datos.setearParametro("@imagen", user.urlImagen);
                datos.setearParametro("@nombre", user.nombre);
                datos.setearParametro("@apellido", user.apellido);
                datos.setearParametro("@fecha", user.fechaNacimiento);
                datos.setearParametro("@id", user.id);
                datos.ejecutarAccion(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
