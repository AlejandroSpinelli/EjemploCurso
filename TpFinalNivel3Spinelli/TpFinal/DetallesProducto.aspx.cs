using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpFinal
{
    public partial class DetallesProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Articulo"] != null)
            {
                Articulo articulo = (Articulo)Session["Articulo"];

                txbCodigo.Text = articulo.Codigo;
                txbNombre.Text = articulo.Nombre;
                txbPrecio.Text = articulo.Precio.ToString();
                txbDescripcion.Text = articulo.Descripcion;
                txbMarca.Text = articulo.marca.Descripcion.ToString();
                txbCategoria.Text = articulo.categoria.Descripcion.ToString();
                if (!string.IsNullOrEmpty(articulo.UrlImagen))
                {
                    //imgImagen.ImageUrl = articulo.UrlImagen;
                    imagencita.Src = articulo.UrlImagen;
                    
                }
                else
                {
                    imagencita.Src = "https://png.pngtree.com/png-vector/20191026/ourmid/pngtree-shopping-basket-icon-png-image_1871519.jpg";
                    //imgImagen.ImageUrl = "https://png.pngtree.com/png-vector/20191026/ourmid/pngtree-shopping-basket-icon-png-image_1871519.jpg";
                }
                

            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }
    }
}