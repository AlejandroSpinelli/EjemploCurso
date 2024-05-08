using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                datos.setearConsulta("select id,email,pass,admin from USERS where email=@mail and pass=@pass");
                datos.setearParametro("@mail", trainee.mail);
                datos.setearParametro("@pass", trainee.pass);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    trainee.id = (int)datos.Lector["id"];
                    trainee.admin = (bool)datos.Lector["admin"];
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

    }
}
