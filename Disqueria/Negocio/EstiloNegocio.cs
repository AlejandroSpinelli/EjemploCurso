using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EstiloNegocio
    {
       public List<Estilos> Listar()
        {
            List<Estilos> lista = new List<Estilos>();
            AccesoADatos datos = new AccesoADatos();
           

            

            try
            {
                datos.establecerconsulta("select Id,Descripcion from Estilos");
                datos.establecerlectura();

                while (datos.Lector.Read())
                {
                    Estilos aux = new Estilos();
                    aux.id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);

                }
                return lista;
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
    }
}
