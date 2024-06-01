using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpFinal
{
    public partial class Administracion : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos { get; set; }
        public bool activarfiltro { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                listaArticulos = negocio.listar();
                Session.Add("ListaArticulos", listaArticulos);
                dgvAdministracion.DataSource = listaArticulos;
                dgvAdministracion.DataBind();

                if (IsPostBack && chbFiltroAvanzado.Checked)
                {
                    activarfiltro = true;
                }

                if (ddlCampo.SelectedValue.ToString() == "Nombre")
                {
                    ddlCriterio.Items.Clear();
                    ddlCriterio.Items.Add("Comienza con");
                    ddlCriterio.Items.Add("Termina con");
                    ddlCriterio.Items.Add("Contiene");
                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void dgvAdministracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = dgvAdministracion.SelectedDataKey.Value.ToString();
                Response.Redirect("Edicion.aspx?Id=" + id,false);
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void dgvAdministracion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                dgvAdministracion.PageIndex = e.NewPageIndex;
                dgvAdministracion.DataBind();
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
                List<Articulo> lista = ((List<Articulo>)Session["ListaArticulos"]);
                List<Articulo> filtrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txbFiltroRapido.Text.ToUpper()));
                dgvAdministracion.DataSource = filtrada;
                dgvAdministracion.DataBind();
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edicion.aspx", false);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
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
                dgvAdministracion.DataSource = listafiltrada;
                dgvAdministracion.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }

        }
    }
}