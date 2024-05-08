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
                Trainee user= new Trainee();
                user.mail=txbUser.Text;
                user.pass=txbPass.Text;
                TraineeNegocio negocio= new TraineeNegocio();

                //insertarnuevo devuelve un entero de un metodo que tiene dentro, ese entero es el id que le vamos a cargar al user
                //luego al user lo cargamos en la session y asi luego del registro se inicia sesion automaticamente.
               user.id= negocio.insetarnuevo(user);
                Session.Add("Trainee", user);
                
                EmailServices services = new EmailServices();
                services.armarCorreo(user.mail, "Bienvenida a la pagina", "Ya podes acceder con tu usuario y contraseña");
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