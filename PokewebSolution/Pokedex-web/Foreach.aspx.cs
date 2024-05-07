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
    public partial class Foreach : System.Web.UI.Page
    {   public List<Pokemon> listapokemon { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listapokemon = negocio.listarconsp();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //string id=Session["pokeid"].ToString();
            //Response.Redirect("Pagina 2.aspx?id=" + id);
        }
    }
}