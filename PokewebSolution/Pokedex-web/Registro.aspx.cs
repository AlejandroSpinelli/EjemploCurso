using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_web
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                Trainee trainee= new Trainee();
                trainee.mail=txbUser.Text;
                trainee.pass=txbPass.Text;
                TraineeNegocio negocio= new TraineeNegocio();

                //insertarnuevo devuelve un entero de un metodo que tiene dentro, ese entero es el id que le vamos a cargar el trainee
                //luego al trainee lo cargamos en la session y asi luego del registro se inicia sesion automaticamente.
                trainee.id= negocio.insetarnuevo(trainee);
                Session.Add("Trainee", trainee);
                
                EmailServices services = new EmailServices();
                services.armarCorreo(trainee.mail, "Bienvenida a la pagina", "Ya podes acceder con tu usuario y contraseña");
                services.enviarMail();
                Response.Redirect("Default.aspx",false);
               

            }
            catch (Exception ex)
            {

                Session.Add("Error",ex.ToString());
            }
        }
    }
}