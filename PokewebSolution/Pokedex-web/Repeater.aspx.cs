using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_web
{
    public partial class Repeater : System.Web.UI.Page
    {   public List<Pokemon> listapokemon {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listapokemon = negocio.listarconsp();

            if (!IsPostBack)
            {
                repRepeater.DataSource = listapokemon;
                repRepeater.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument;
            Response.Redirect("Pagina 2.aspx?id=" + id);
        }
    }
}