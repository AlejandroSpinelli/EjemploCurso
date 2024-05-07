using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Pokedex_web
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            EmailServices emailservicio=new EmailServices();
            emailservicio.armarCorreo(txbMail.Text, txbAsunto.Text, txbMensaje.Text);
            try
            {
                emailservicio.enviarMail();
                Session.Add("Error", "Hemos recibido su correo electronico");
                Response.Redirect("Error.aspx");
            }
            catch (Exception ex)
            {
                Session.Add("Error",ex.ToString());
                throw;
            }
        }
    }
}