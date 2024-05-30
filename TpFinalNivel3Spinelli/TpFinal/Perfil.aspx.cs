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
            try
            {
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
                            imgPerfil.ImageUrl = "~/Images/ImagenPerfil/" + user.UrlImagenPerfil;
                        }

                        Session["uaser"] = user;

                    }
                }
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
           UserLog user = (UserLog)Session["User"];
           LoginNegocio negocio = new LoginNegocio();

            try
            {

                if (!string.IsNullOrEmpty(txbNombre.Text))
                {
                    user.Nombre= txbNombre.Text;
                }
                if (!string.IsNullOrEmpty(txbApellido.Text))
                {
                    user.Apellido= txbApellido.Text;
                }
                if (txtImagen.PostedFile.FileName != "")
                {
                    string ruta = Server.MapPath("./Images/ImagenPerfil/");
                    txtImagen.PostedFile.SaveAs(ruta + "IMGPerfil-" + user.Id + ".jpg");
                    user.UrlImagenPerfil = "IMGPerfil-" + user.Id + ".jpg";
                }
                negocio.Modificar(user);
                Session.Add("Message", "Usuario modificado con exito!");
                Response.Redirect("Error.aspx", false);

                Image img = (Image)Master.FindControl("imgUser");
                img.ImageUrl = "~/Images/ImagenPerfil/" + user.UrlImagenPerfil;
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}