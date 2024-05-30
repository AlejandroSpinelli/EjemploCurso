using Dominio;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpFinal
{
    
    public partial class Favoritos : System.Web.UI.Page
    {
        public List<Articulo> lista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["User"] != null)
                {
                    UserLog user = (UserLog)Session["User"];
                    int id = user.Id;
                    ArticulosNegocio negocio = new ArticulosNegocio();
                    lista = negocio.MostrarFavoritos(id);
                    if (!IsPostBack)
                    {
                        repRepeater.DataSource = lista;
                        repRepeater.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }


        }

        protected void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["user"] != null)
                {
                    Button btnFav = (Button)sender;
                    int idarticulo = int.Parse(btnFav.CommandArgument);

                    UserLog user = (UserLog)Session["user"];

                    ArticulosNegocio negocio = new ArticulosNegocio();
                    negocio.EliminarFavorito(idarticulo, user.Id);
                    Response.Redirect("Favoritos.aspx", false);
                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }

        }
    }
}