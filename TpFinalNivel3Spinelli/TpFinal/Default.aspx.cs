using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpFinal
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Articulo> lista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            lista = negocio.listar();
            if (!IsPostBack)
            {
                repRepeater.DataSource = lista;
                repRepeater.DataBind();
            }
            
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {

            string id = ((Button)sender).CommandArgument;
            Response.Redirect("DetallesProducto.aspx?id=" + id);
        }

        protected void btnFav_Click(object sender, EventArgs e)
        {
            Button btnFav = (Button)sender;

            int id= int.Parse(btnFav.CommandArgument);
        }
    }
}