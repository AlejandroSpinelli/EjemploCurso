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
    public partial class Gridview : System.Web.UI.Page
    {
        public List<Pokemon> listapokemon { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listapokemon = negocio.nuevometodo();
            dgvPokemon.DataSource = listapokemon;
            dgvPokemon.DataBind();
        }

        protected void dgvPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Id= dgvPokemon.SelectedDataKey.Value.ToString();
            Response.Redirect("Pagina 2.aspx?Id=" +  Id);
        }

        protected void dgvPokemon_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvPokemon.PageIndex= e.NewPageIndex;
            dgvPokemon.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pagina 2.aspx");
        }
    }
}