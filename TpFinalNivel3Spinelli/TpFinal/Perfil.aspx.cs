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
    public partial class Perfil : System.Web.UI.Page
    {   

        protected void Page_Load(object sender, EventArgs e)
        {
            UserLog user = (UserLog)Session["User"];
            if (!IsPostBack)
            {
                if (Session["User"] != null)
                {
                    txbEmail.Text = user.Email;
                    txbEmail.Enabled = false;

                    if (!string.IsNullOrEmpty(user.Nombre))
                    {
                        txbNombre.Text = user.Nombre;
                    }

                    if (!string.IsNullOrEmpty(user.Apellido))
                    {
                        txbApellido.Text += user.Apellido;
                    }

                    if (!string.IsNullOrEmpty(user.UrlImagenPerfil))
                    {
                        imgPerfil.ImageUrl = user.UrlImagenPerfil;
                    }

                    Session["uaser"] = user;

                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
           UserLog user = (UserLog)Session["User"];
           LoginNegocio negocio = new LoginNegocio();

            try
            {
                if(!string.IsNullOrEmpty(txbNombre.Text))
                {
                    user.Nombre= txbNombre.Text;
                }
                if (!string.IsNullOrEmpty(txbApellido.Text))
                {
                    user.Apellido= txbApellido.Text;
                }
                if (!string.IsNullOrEmpty(txtImagen.Value.ToString()))
                {
                    user.UrlImagenPerfil= txtImagen.Value.ToString();
                }
                negocio.Modificar(user);
                Session.Add("Message", "Usuario modificado con exito!");
                Response.Redirect("Error.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}