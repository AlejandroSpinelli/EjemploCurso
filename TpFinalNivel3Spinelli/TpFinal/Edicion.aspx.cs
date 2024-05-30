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
    public partial class Edicion : System.Web.UI.Page
    {
        public bool mostrarModificar { get; set; }
        public bool mostrarEliminar { get; set; }
        public bool mostrarComandos { get; set; }

        CategoriaNegocio negocioCategoria = new CategoriaNegocio();
        List<Categoria> categoria = new List<Categoria>();
        MarcaNegocio negocioMarca = new MarcaNegocio();
        List<Marca> marcas = new List<Marca>();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    mostrarComandos = true;
                    btnAgregar.Enabled = false;
                }
                else
                {
                    mostrarComandos = false;
                }
                mostrarModificar = false;
                mostrarEliminar = false;

                if (!IsPostBack)
                {
                    marcas = negocioMarca.listar();
                    ddlMarca.DataSource = marcas;
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataTextField = "Descripcion";
                    ddlMarca.DataBind();

                    categoria = negocioCategoria.listar();
                    ddlCategoria.DataSource = categoria;
                    ddlCategoria.DataValueField = "Id";
                    ddlCategoria.DataTextField = "Descripcion";
                    ddlCategoria.DataBind();
                }

                string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";

                if (!IsPostBack && !string.IsNullOrEmpty(id))
                {

                    ArticulosNegocio negocio = new ArticulosNegocio();
                    Articulo seleccionado = new Articulo();
                    seleccionado = (negocio.listar(id))[0];
                    Session.Add("Seleccionado",seleccionado );
                    

                    txbNombre.Text = seleccionado.Nombre;
                    txbCodigo.Text = seleccionado.Codigo;
                    txbDescripcion.Text = seleccionado.Descripcion;
                    txbPrecio.Text = seleccionado.Precio.ToString();
                    imgArticulo.ImageUrl = seleccionado.UrlImagen != null ? seleccionado.UrlImagen : "";

                    ddlCategoria.SelectedValue = seleccionado.IdCategoria.ToString();
                    ddlMarca.SelectedValue = seleccionado.IdMarca.ToString();


                }


            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }



        protected void btnModificar_Click1(object sender, EventArgs e)
        {
            if (mostrarModificar == false)
            {
                mostrarModificar = true;
            }

        }

        protected void btnModificarValidado_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbmodificar.Checked)
                {
                    
                    ArticulosNegocio negocio = new ArticulosNegocio();
                    Articulo seleccionado = (Articulo)Session["seleccionado"];
                    if (!string.IsNullOrEmpty(txbCodigo.Text))
                    {
                        seleccionado.Codigo = txbCodigo.Text;
                    }


                    if (!string.IsNullOrEmpty(txbNombre.Text))
                    {
                        seleccionado.Nombre = txbNombre.Text;
                    }


                    if (!string.IsNullOrEmpty(txbPrecio.Text))
                    {
                        seleccionado.Precio = int.Parse(txbPrecio.Text);
                    }

                    if (!string.IsNullOrEmpty(txbDescripcion.Text))
                    {
                        seleccionado.Descripcion = txbDescripcion.Text;
                    }
                    seleccionado.categoria = new Categoria();
                    if (!string.IsNullOrEmpty(ddlCategoria.SelectedValue))
                    {
                        seleccionado.categoria.Id = int.Parse(ddlCategoria.SelectedValue);
                    }

                    seleccionado.marca = new Marca();
                    if (!string.IsNullOrEmpty(ddlMarca.SelectedValue))
                    {
                        seleccionado.marca.Id = int.Parse(ddlMarca.SelectedValue);
                    }
                    negocio.Modificar(seleccionado);
                    Response.Redirect("Default.aspx", false);
                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (mostrarEliminar == false)
            {
                mostrarEliminar = true;
            }
        }

        protected void btnEliminarValidado_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbeliminar.Checked)
                {
                    ArticulosNegocio negocio = new ArticulosNegocio();
                    negocio.EliminarFisico((Articulo)Session["Seleccionado"]);
                    Response.Redirect("Default.aspx", false);
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
            try
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                Articulo seleccionado = new Articulo();
                if (!string.IsNullOrEmpty(txbCodigo.Text))
                {
                    seleccionado.Codigo = txbCodigo.Text;
                }


                if (!string.IsNullOrEmpty(txbNombre.Text))
                {
                    seleccionado.Nombre = txbNombre.Text;
                }


                if (!string.IsNullOrEmpty(txbPrecio.Text))
                {
                    seleccionado.Precio = int.Parse(txbPrecio.Text);
                }

                if (!string.IsNullOrEmpty(txbDescripcion.Text))
                {
                    seleccionado.Descripcion = txbDescripcion.Text;
                }
                seleccionado.categoria = new Categoria();
                if (!string.IsNullOrEmpty(ddlCategoria.SelectedValue))
                {
                    seleccionado.categoria.Id = int.Parse(ddlCategoria.SelectedValue);
                }

                seleccionado.marca = new Marca();
                if (!string.IsNullOrEmpty(ddlMarca.SelectedValue))
                {
                    seleccionado.marca.Id = int.Parse(ddlMarca.SelectedValue);
                }



                //Falta agregar lo de la imagen

                if (string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    negocio.Cargar(seleccionado);
                    Response.Redirect("Default.aspx", false);
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