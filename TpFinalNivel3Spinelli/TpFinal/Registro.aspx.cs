using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpFinal
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            LoginNegocio negocio = new LoginNegocio();
            UserLog user = new UserLog();
            user.Email= txbEmail.Text;
            user.Contraseña=txbPass.Text;

            negocio.registrar(user);


            //Falta resolver el tema del correo electronico
            string message = "Usuario registrado con exito,logueate!";
            Session.Add("message", message);
            Response.Redirect("Error.aspx", false);
        }
    }
}