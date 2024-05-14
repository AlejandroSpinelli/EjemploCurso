using negocio;
using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        public bool mostrarBotones { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page is Default || Page is Registro || Page is Error||Page is Error))
            {
                if (!(Seguridad.SessionActiva(Session["Trainee"])))
                {
                    Response.Redirect("Default.aspx", false);
                }
                
            }



            if (Seguridad.SessionActiva(Session["Trainee"]))
            {
                mostrarBotones = false;
                ImgAvatar.ImageUrl = "~/Images/" + ((Trainee)Session["Trainee"]).urlImagen;
                lbluser.Text = ((Trainee)Session["trainee"]).mail;
            }
            else
            {
                ImgAvatar.ImageUrl = "https://static.vecteezy.com/system/resources/thumbnails/004/511/281/small_2x/default-avatar-photo-placeholder-profile-picture-vector.jpg";
                mostrarBotones = true;
            }




        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btndesloguearse_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx", false);
        }
    }
}