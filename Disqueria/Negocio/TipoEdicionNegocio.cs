using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TipoEdicionNegocio
    {
        public List<TipoEdicion> Listar()
        {
            List<TipoEdicion> lista = new List<TipoEdicion>();
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.establecerconsulta("select Id,Descripcion from TIPOSEDICION");
                datos.establecerlectura();

                while (datos.Lector.Read())
                {
                    TipoEdicion aux = new TipoEdicion();
                    aux.id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }
    }
}
