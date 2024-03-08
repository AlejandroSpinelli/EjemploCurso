using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
       
        {
                AccesoADatos datos = new AccesoADatos();
                List<Categoria> lista = new List<Categoria>();

                try
                {
                    datos.establecerConsulta("select Id,Descripcion from CATEGORIAS");
                    datos.establecerlectura();

                    while (datos.Lector.Read())
                    {
                        Categoria aux = new Categoria();
                        aux.Id = (int)datos.Lector["Id"];
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
