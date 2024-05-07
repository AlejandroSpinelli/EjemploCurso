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
        public bool habilitarfiltrorapido { get; set; }

        public List<Pokemon> listapokemon { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listapokemon = negocio.listartodoconSp();
            Session.Add("listapokemon", listapokemon);
            dgvPokemon.DataSource = listapokemon;
            dgvPokemon.DataBind();

            if (IsPostBack)
            {
                CheckBox1_CheckedChanged(sender, e); 
            }

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

        protected void txbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> lista = ((List < Pokemon >) Session["listapokemon"]);
            List<Pokemon> filtrada= lista.FindAll(x => x.Nombre.ToUpper().Contains(txbFiltroRapido.Text.ToUpper()));
            dgvPokemon.DataSource = filtrada;
            dgvPokemon.DataBind();
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFiltrorapido.Checked)
            {
                habilitarfiltrorapido = true;
            }

            txbFiltroRapido.Enabled = !habilitarfiltrorapido;
            
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string campo=ddlCampo.Text;
                string criterio=ddlCriterio.Text;
                string filtro=txbFiltro.Text;
                string Activo=ddlEstado.Text;
                PokemonNegocio negocio = new PokemonNegocio();
                dgvPokemon.DataSource= negocio.filtrar(campo, criterio, filtro, Activo);
                dgvPokemon.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
                throw;
            }
        }

        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlCampo.SelectedItem.ToString())
            {
                case "Nombre":
                    ddlCriterio.Items.Clear();
                    ddlCriterio.Items.Add("Comienza con");
                    ddlCriterio.Items.Add("Termina con");
                    ddlCriterio.Items.Add("Contiene");

                    break;
                case "Tipo":
                    ddlCriterio.Items.Clear();
                    ElementoNegocio negocioelemento = new ElementoNegocio();
                    List<Elemento> elementos = negocioelemento.listar();

                    foreach (Elemento elemento in elementos)
                    {
                        ddlCriterio.Items.Add(elemento.Descripcion.ToString());
                    }

                    break;
                case "Número":

                    ddlCriterio.Items.Clear();
                    ddlCriterio.Items.Add("Mayor a");
                    ddlCriterio.Items.Add("Menor a");
                    ddlCriterio.Items.Add("Igual a");

                    break;
            
            }
        }
    }
}