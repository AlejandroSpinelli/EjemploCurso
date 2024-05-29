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
    public partial class Site : System.Web.UI.MasterPage
    {
        public bool Mostrar { get; set; }
        public bool AdminOn { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Mostrar = false;
            AdminOn = false;
            if (!(Page is Default || Page is Registro || Page is Error || Page is Login || Page is DetallesProducto))
            {
                if (!Seguridad.SessionActiva(Session["User"]))
                {
                    Response.Redirect("Default.aspx", false);
                }
            }

            if (!Seguridad.SessionActiva(Session["User"]))
            {
                imgUser.ImageUrl = "https://st3.depositphotos.com/6672868/13701/v/450/depositphotos_137014128-stock-illustration-user-profile-icon.jpg";
            }


            if (Seguridad.SessionActiva(Session["User"]))
            {
                UserLog user = (UserLog)Session["user"];
                Mostrar = true;
                lblCorreo.Text = user.Email;
                if (!string.IsNullOrEmpty(user.UrlImagenPerfil))
                {
                    imgUser.ImageUrl = "~/Images/ImagenPerfil/" + ((UserLog)Session["User"]).UrlImagenPerfil;
                }
                else
                {
                    imgUser.ImageUrl = "https://st3.depositphotos.com/6672868/13701/v/450/depositphotos_137014128-stock-illustration-user-profile-icon.jpg";
                }

                btnIgresar.Text = "Salir";

                if (Seguridad.esAdmin(Session["User"]))
                {
                    AdminOn = true;
                }
                else
                {
                    AdminOn = false;
                }

            }

        }

        protected void btnIgresar_Click(object sender, EventArgs e)
        {
            if (Seguridad.SessionActiva(Session["user"]))
            {
                Session.Clear();
                Response.Redirect("Default.aspx", false);
            }
            else
            {
                Response.Redirect("Login.aspx", false);
            }

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx", false);
        }
    }
}