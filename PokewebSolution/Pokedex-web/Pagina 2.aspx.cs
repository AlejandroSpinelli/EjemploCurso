using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_web
{
    public partial class Pagina_2 : System.Web.UI.Page
    {
        public bool Confirmaeliminacion { get; set; }
        public bool ConfirmaDesactivar{ get; set; }
        ElementoNegocio negocio = new ElementoNegocio();
        List<Elemento> elementos = new List<Elemento>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Confirmaeliminacion = false;
            pokeid.Enabled = false;

            try
            {
                //configuracion inicial de la pantalla
                if (!IsPostBack)
                {
                    elementos = negocio.listar();
                    poketipo.DataSource = elementos;
                    poketipo.DataValueField = "id";
                    poketipo.DataTextField = "Descripcion";
                    poketipo.DataBind();

                    pokedebilidad.DataSource = elementos;
                    pokedebilidad.DataValueField = "id";
                    pokedebilidad.DataTextField = "Descripcion";
                    pokedebilidad.DataBind();

                    
                }


                //configuracion si estamos modificando.
                //usasndo operador ternario
                string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
                

                if (id!="" && !IsPostBack)
                {
                    PokemonNegocio negocio = new PokemonNegocio();
                    Pokemon seleccionado= (negocio.listar(id))[0];

                    pokenombre.Text = seleccionado.Nombre;
                    pokenumero.Text = seleccionado.Numero.ToString();
                    pokeid.Text = seleccionado.Id.ToString();
                    pokedescripcion.Text = seleccionado.Descripcion;
                    poketipo.SelectedValue = seleccionado.Tipo.Id.ToString();
                    pokedebilidad.SelectedValue = seleccionado.Debilidad.Id.ToString();
                    pokeurl.Text = seleccionado.UrlImagen;

                    //guardo el pokemon en session para poder usar en la activacion o desactivacion del mismo en el evento
                    Session.Add("PokemonSeleccionado", seleccionado);

                    pokeurl_TextChanged(sender, e);

                    if (!seleccionado.Activo)
                    {
                        btnDesactivar.Text = "Reactivar";
                        btnConfirmarDesactivar.Text = "Reactivar";
                        chbDesactivar.Text = "Para reactivar tilde el checkbox";
                    }

                }


            }
            catch (Exception ex)
            {

                Session.Add("Error", ex);
                //redireccion a una pagina de error;
                throw;
            }
        }

        protected void pokeurl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                imgPoke.ImageUrl = pokeurl.Text;
            }
            catch (Exception)
            {

            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                Pokemon pokemon = new Pokemon();
                
                pokemon.Nombre = pokenombre.Text;
                pokemon.Numero = int.Parse(pokenumero.Text);
                pokemon.Descripcion = pokedescripcion.Text;
                pokemon.UrlImagen = pokeurl.Text;
                pokemon.Tipo = new Elemento();
                pokemon.Tipo.Id = int.Parse(poketipo.SelectedValue);
                pokemon.Debilidad = new Elemento();
                pokemon.Debilidad.Id = int.Parse(pokedebilidad.SelectedValue);




                PokemonNegocio negocio = new PokemonNegocio();


                if (Request.QueryString["Id"] != null)
                {
                    pokemon.Id = int.Parse(pokeid.Text);
                    negocio.modificarconsp(pokemon);
                }
                else
                {
                    negocio.agregarconsp(pokemon);
                }

                Response.Redirect("Gridview.aspx", false);

            }
            catch (Exception ex)
            {
                Session.Add("Error", ex);
                throw;
            }
        }

        
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Confirmaeliminacion)
            {
                Confirmaeliminacion= true;
            }
        }

        protected void btnConfirmaEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbEliminar.Checked)
                {
                    string id = Request.QueryString["Id"];
                    PokemonNegocio negocio = new PokemonNegocio();
                    negocio.eliminar(int.Parse(id));
                    Response.Redirect("Gridview.aspx");
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error",ex);
                throw;
            }
        }

        protected void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (!ConfirmaDesactivar)
            {
                ConfirmaDesactivar= true;
            }
        }

        protected void btnConfirmarDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbDesactivar.Checked)
                {
                    Pokemon seleccionado = (Pokemon)Session["PokemonSeleccionado"];
                    PokemonNegocio negocio = new PokemonNegocio();
                    //negocio.eliminarLogico(int.Parse(Request.QueryString["Id"]));
                    negocio.eliminarLogico(seleccionado.Id,!seleccionado.Activo);
                    Response.Redirect("Gridview.aspx");
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                
            }
        }
    }
}