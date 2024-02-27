using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class DiscosNegocio
    {

        public List<Discos> listar()
        {
            List<Discos>lista = new List<Discos>();
            AccesoADatos datos = new AccesoADatos();
            datos.establecerconsulta("select D.Id as Id,Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,T.Descripcion as Edicion,E.Descripcion as Estilo,D.IdEstilo as IdEstilo,D.IdTipoEdicion as IdTipoEdicion from DISCOS D,ESTILOS E, TIPOSEDICION T where IdEstilo=E.Id and IdTipoEdicion=T.Id");
            datos.establecerlectura();

            try
            {
                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];

                    if(datos.Lector!=null)
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    aux.Estilo = new Estilos();
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.Estilo.id = (int)datos.Lector["IdEstilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Descripcion = (string)datos.Lector["Edicion"];   
                    aux.Edicion.id = (int)datos.Lector["IdTipoEdicion"];
                    


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


        public void cargar(Discos disco)
        {
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.establecerconsulta("insert into DISCOS(Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion) values (@Titulo,@FechaLanzamiento,@CantidadCanciones,@UrlImagen,@IdEstilo,@IdFormato)");

                datos.SetearParametros("@Titulo", disco.Titulo);
                datos.SetearParametros("@FechaLanzamiento", disco.FechaLanzamiento);
                datos.SetearParametros("@CantidadCanciones", disco.CantidadCanciones);
                datos.SetearParametros("@UrlImagen", disco.UrlImagenTapa);
                datos.SetearParametros("@IdEstilo", disco.Estilo.id);
                datos.SetearParametros("@IdFormato", disco.Edicion.id);

                datos.ejecutraraccion();

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


        public void eliminar(int id)
        {
            AccesoADatos datos=new AccesoADatos();

            try
            {
                datos.establecerconsulta("delete from DISCOS where id=@id");
                datos.SetearParametros("@id",id);
                datos.ejecutraraccion();
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


        public void modificar(Discos disco)
        {
            AccesoADatos datos = new AccesoADatos();

            try
            {
                datos.establecerconsulta("update DISCOS set Titulo=@Titulo,FechaLanzamiento=@Fecha,CantidadCanciones=@CantidadCanciones,UrlImagenTapa=@Url,IdEstilo=@Estilo,IdTipoEdicion=@Edicion where Id=@Id");
                datos.SetearParametros("@Titulo", disco.Titulo);
                datos.SetearParametros("@Fecha", disco.FechaLanzamiento);
                datos.SetearParametros("@CantidadCanciones", disco.CantidadCanciones);
                datos.SetearParametros("@Url", disco.UrlImagenTapa);
                datos.SetearParametros("@Estilo", disco.Estilo.id);
                datos.SetearParametros("@Edicion", disco.Edicion.id);
                datos.SetearParametros("@Id", disco.Id);
                datos.ejecutraraccion();
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

        public List<Discos> filtrar(string campo, string criterio, string filtro)
        {
            AccesoADatos datos = new AccesoADatos();
            List<Discos> lista = new List<Discos>();
            try
            {
                string consulta = "select D.Id as Id,Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,T.Descripcion as Edicion,E.Descripcion as Estilo,D.IdEstilo as IdEstilo,D.IdTipoEdicion as IdTipoEdicion from DISCOS D,ESTILOS E, TIPOSEDICION T where IdEstilo=E.Id and IdTipoEdicion=T.Id and ";
                datos.establecerconsulta(consulta);

                switch (campo)
                {
                    case "Cantidad de Canciones":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "CantidadCanciones > @filtro"; // o tambien consulta += "CantidadCanciones >" +filtro;
                                datos.SetearParametros("@filtro", filtro);
                                break;
                            case "Menor a":
                                consulta += "CantidadCanciones < @filtro";
                                datos.SetearParametros("@filtro", filtro);
                                break;
                            case "Igual a":
                                consulta += "CantidadCanciones = @filtro";
                                datos.SetearParametros("@filtro", filtro);
                                break;
                        }
                        break;
                    case "Título":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Titulo like '"+filtro+"%'";
                                break;
                            case "Termina con":
                                consulta += "Titulo like '%" + filtro + "'";
                                break;
                            case "Contiene":
                                consulta += "Titulo like '%" + filtro + "%'";
                                break;
                        }

                        break;
                }

                datos.establecerconsulta(consulta);
                datos.establecerlectura();

                while (datos.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];

                    if (datos.Lector != null)
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];

                    aux.Estilo = new Estilos();
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.Estilo.id = (int)datos.Lector["IdEstilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Descripcion = (string)datos.Lector["Edicion"];
                    aux.Edicion.id = (int)datos.Lector["IdTipoEdicion"];



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
