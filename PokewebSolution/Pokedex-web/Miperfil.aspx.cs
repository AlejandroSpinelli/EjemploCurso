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
    }
}