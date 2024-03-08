using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticulosNegocio
    {
       AccesoADatos datos=new AccesoADatos();
       public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            datos.establecerConsulta("select A.Id as Id,Codigo,Nombre,A.Descripcion as Descripcion,ImagenUrl,IdCategoria,IdMarca,C.Descripcion as Categoria, M.Descripcion as Marca,Precio from ARTICULOS A,MARCAS M,CATEGORIAS C where A.IdMarca=M.Id and A.IdCategoria=C.Id");
            datos.establecerlectura();

            while (datos.Lector.Read())
            {
                Articulo aux = new Articulo();
                aux.Id = (int)datos.Lector["Id"];
                aux.Codigo = (string)datos.Lector["Codigo"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Descripcion = (string)datos.Lector["Descripcion"];
                aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                aux.IdMarca = (int)datos.Lector["IdMarca"];
                aux.categoria = new Categoria();
                aux.categoria.Descripcion = (string)datos.Lector["Categoria"];
                aux.marca = new Marca();
                aux.marca.Descripcion = (string)datos.Lector["Marca"];
                aux.Precio = (decimal)datos.Lector["Precio"];

                lista.Add(aux);
            }
            datos.cerrarconexion();
            return lista;

        }

       public void Cargar(Articulo Articulo)
        {
            AccesoADatos datos = new AccesoADatos();

            datos.establecerConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,ImagenUrl,IdCategoria,IdMarca,precio) values (@Codigo,@Nombre,@Descripcion,@ImagenUrl,@IdCategoria,@IdMarca,@Precio)");

            datos.setearparametros("@Codigo", Articulo.Codigo);
            datos.setearparametros("@Nombre", Articulo.Nombre);
            datos.setearparametros("@Descripcion", Articulo.Descripcion);
            datos.setearparametros("@ImagenUrl", Articulo.UrlImagen);
            datos.setearparametros("@IdCategoria", Articulo.categoria.Id);
            datos.setearparametros("@IdMarca",Articulo.marca.Id);
            datos.setearparametros("@Precio" ,Articulo.Precio);

            datos.ejecutaraccion();
        }

       public void Modificar(Articulo articulo)
        {
            AccesoADatos datos=new AccesoADatos();

            try
            {
                datos.establecerConsulta("update ARTICULOS set Codigo=@Codigo,Nombre=@Nombre,Descripcion=@Descripcion,ImagenUrl=@ImagenUrl,IdCategoria=@Categoria,IdMarca=@Marca,Precio=@Precio where id=@Id");

                datos.setearparametros("@Codigo",articulo.Codigo);
                datos.setearparametros("@Nombre",articulo.Nombre);
                datos.setearparametros("@Descripcion", articulo.Descripcion);
                datos.setearparametros("@Marca",articulo.marca.Id);
                datos.setearparametros("@Categoria",articulo.categoria.Id);
                datos.setearparametros("@ImagenUrl", articulo.UrlImagen);
                datos.setearparametros("@Precio",articulo.Precio);
                datos.setearparametros("@Id",articulo.Id);

                datos.ejecutaraccion();

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

       public void EliminarFisico (Articulo Articulo)
        {
            AccesoADatos datos=new AccesoADatos();
            
            try
            {
                datos.establecerConsulta("delete from ARTICULOS where id=@Id");
                datos.setearparametros("@Id", Articulo.Id);
                datos.ejecutaraccion();
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

       public List<Articulo> filtroavanzado(string campo, string criterio, string filtro)
        {
            AccesoADatos datos =new AccesoADatos();
            List<Articulo> lista = new List<Articulo>();

            string consulta = "select A.Id as Id,Codigo,Nombre,A.Descripcion as Descripcion,ImagenUrl,IdCategoria,IdMarca,C.Descripcion as Categoria, M.Descripcion as Marca,Precio from ARTICULOS A,MARCAS M,CATEGORIAS C where A.IdMarca=M.Id and A.IdCategoria=C.Id and ";
            datos.establecerConsulta(consulta);

            try
            {
                switch (campo)
                {
                    case ("Precio"):
                        switch (criterio)
                        {
                            case ("Mayor a"):
                                consulta += "Precio > @Filtro";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Menor a"):
                                consulta += "Precio < @Filtro";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Igual a"):
                                consulta += "Precio = @Filtro";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                        }break;
                   

                    case ("Codigo"):
                        switch (criterio)
                        {
                            case ("Comienza con"):
                                consulta += "Codigo like '"+filtro+ "%'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Termina con"):
                                consulta += "Codigo like '%"+filtro+"'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Contiene"):
                                consulta += "Codigo like '%"+filtro+"%'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                        }
                    break;

                    case ("Nombre"):
                        switch (criterio)
                        {
                            case ("Comienza con"):
                                consulta += "Nombre like '" + filtro + "%'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Termina con"):
                                consulta += "Nombre like '%" + filtro + "'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Contiene"):
                                consulta += "Nombre like '%" + filtro + "%'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                        }
                        break;

                    case ("Descripcion"):
                        switch (criterio)
                        {
                            case ("Comienza con"):
                                consulta += "A.Descripcion like '" + filtro + "%'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Termina con"):
                                consulta += "A.Descripcion like '%" + filtro + "'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Contiene"):
                                consulta += "A.Descripcion like '%" + filtro + "%'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                        }
                        break;

                    case ("Marca"):
                        switch (criterio)
                        {
                            case ("Comienza con"):
                                consulta += "M.Descripcion like '" + filtro + "%'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Termina con"):
                                consulta += "M.Descripcion like '%" + filtro + "'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Contiene"):
                                consulta += "M.Descripcion like '%" + filtro + "%'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                        }
                        break;

                    case ("Categoria"):
                        switch (criterio)
                        {
                            case ("Comienza con"):
                                consulta += "C.Descripcion like '" + filtro + "%'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Termina con"):
                                consulta += "C.Descripcion like '%" + filtro + "'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                            case ("Contiene"):
                                consulta += "C.Descripcion like '%" + filtro + "%'";
                                datos.setearparametros("@Filtro", filtro);
                                break;
                        }
                        break;



                }


                datos.establecerConsulta(consulta);
                datos.establecerlectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.categoria = new Categoria();
                    aux.categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.marca = new Marca();
                    aux.marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                datos.cerrarconexion();

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
