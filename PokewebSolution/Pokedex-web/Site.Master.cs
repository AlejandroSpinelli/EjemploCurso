using negocio;
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
            if(!(Page is Default || Page is Registro))
            {
                if (!(Seguridad.SessionActiva(Session["Trainee"])))
                {
                    Response.Redirect("Default.aspx", false);
                }
            }

            if (Seguridad.SessionActiva(Session["Trainee"]))
            {
                mostrarBotones = false;
            }
            else
            {
                mostrarBotones=true;
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