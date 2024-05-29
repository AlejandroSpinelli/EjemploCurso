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
    {   public bool mostrar {  get; set; }
        public List<Articulo> lista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrar = false;
            if (Session["User"] != null)
            {
                mostrar = true;
            }
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

            Button btnDetalle = (Button)sender;
            string idarticulo = btnDetalle.CommandArgument.ToString();

            ArticulosNegocio negocio=new ArticulosNegocio();
            Articulo articulo = (negocio.listar(idarticulo))[0];



            Session.Add("Articulo", articulo);
            Response.Redirect("DetallesProducto.aspx", false);


        }

        protected void btnFav_Click(object sender, EventArgs e)
        {
            if (Session["user"]!=null)
            {
                Button btnFav = (Button)sender;
                int idarticulo = int.Parse(btnFav.CommandArgument);

                UserLog user= (UserLog)Session["user"];

                ArticulosNegocio negocio=new ArticulosNegocio();
                negocio.CargarFavorito(idarticulo, user.Id);

            }

        }
    }
}