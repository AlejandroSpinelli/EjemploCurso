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
            string nombre= dgvPokemon.SelectedDataKey.Value.ToString();
            Response.Redirect("Default.aspx?nombre=" +  nombre);
        }
    }
}