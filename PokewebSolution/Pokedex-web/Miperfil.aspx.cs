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
    public partial class Miperfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Trainee trainee = (Trainee)Session["Trainee"] != null ? (Trainee)Session["Trainee"] : null;

            
                if (!(Seguridad.SessionActiva(Session["Trainee"])))
                {
                    Response.Redirect("Default.aspx", false);
                }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string ruta = Server.MapPath("./Images/");
                Trainee user = (Trainee)Session["Trainee"];
                txtImg.PostedFile.SaveAs(ruta + "perfil-" + user.id + ".jpg");
                Response.Redirect("Default.aspx", false);

            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
            }
        }
    }
}