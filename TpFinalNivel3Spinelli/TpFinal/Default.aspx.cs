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
        public bool activarfiltro { get; set; }
        public List<Articulo> lista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            try
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

                if (IsPostBack && chbFiltroAvanzado.Checked)
                {
                    activarfiltro = true;
                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
           

        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {

            try
            {
                Button btnDetalle = (Button)sender;
                string idarticulo = btnDetalle.CommandArgument.ToString();

                ArticulosNegocio negocio = new ArticulosNegocio();
                Articulo articulo = (negocio.listar(idarticulo))[0];



                Session.Add("Articulo", articulo);
                Response.Redirect("DetallesProducto.aspx", false);
            }
            catch (Exception)
            {

                throw;
            }


        }

        protected void btnFav_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["user"] != null)
                {
                    Button btnFav = (Button)sender;
                    int idarticulo = int.Parse(btnFav.CommandArgument);

                    UserLog user = (UserLog)Session["user"];

                    ArticulosNegocio negocio = new ArticulosNegocio();
                    bool respuesta = negocio.ChequearFavorito(user.Id, idarticulo);
                    //aca hay que chequear si el articulo ya esta en la lista de favoritos del user
                    if (respuesta == false)
                    {
                        negocio.CargarFavorito(idarticulo, user.Id);
                    }
                    
                    

                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }

        }

        protected void txbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //List<Articulo> lista = ((List<Articulo>)Session["ListaArticulos"]);
                List<Articulo> filtrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txbFiltroRapido.Text.ToUpper()));
                repRepeater.DataSource = filtrada;
                repRepeater.DataBind();
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void chbFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbFiltroAvanzado.Checked)
                {
                    activarfiltro = true;
                }
                else
                {
                    activarfiltro = false;
                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (ddlCampo.SelectedItem.ToString())
                {
                    case "Nombre":
                        ddlCriterio.Items.Clear();
                        ddlCriterio.Items.Add("Comienza con");
                        ddlCriterio.Items.Add("Termina con");
                        ddlCriterio.Items.Add("Contiene");
                        break;
                    case "Marca":
                        ddlCriterio.Items.Clear();
                        ddlCriterio.Items.Add("Comienza con");
                        ddlCriterio.Items.Add("Termina con");
                        ddlCriterio.Items.Add("Contiene");
                        break;
                    case "Categoria":
                        ddlCriterio.Items.Clear();
                        ddlCriterio.Items.Add("Comienza con");
                        ddlCriterio.Items.Add("Termina con");
                        ddlCriterio.Items.Add("Contiene");
                        break;
                    case "Precio":
                        ddlCriterio.Items.Clear();
                        ddlCriterio.Items.Add("Mayor a");
                        ddlCriterio.Items.Add("Menor a");
                        ddlCriterio.Items.Add("Igual a");
                        break;
                    case "Descripcion":
                        ddlCriterio.Items.Clear();
                        ddlCriterio.Items.Add("Contiene");
                        break;
                    case "Codigo":
                        ddlCriterio.Items.Clear();
                        ddlCriterio.Items.Add("Comienza con");
                        ddlCriterio.Items.Add("Termina con");
                        ddlCriterio.Items.Add("Contiene");
                        break;
                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string campo = ddlCampo.SelectedValue.ToString();
                string criterio = ddlCriterio.SelectedValue.ToString();
                string filtro = txbFiltro.Text;
                ArticulosNegocio negocio = new ArticulosNegocio();
                List<Articulo> listafiltrada = new List<Articulo>();
                listafiltrada = negocio.filtroavanzado(campo, criterio, filtro);


                repRepeater.DataSource = listafiltrada;
                repRepeater.DataBind();
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}