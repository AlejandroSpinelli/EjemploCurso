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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginNegocio negocio = new LoginNegocio();
                UserLog user = new UserLog();

                user.Email = txbEmail.Text;
                user.Contraseña = txbPass.Text;

                if (int.Parse(negocio.ingresar(user).Id.ToString()) != 0)
                {
                    user = negocio.ingresar(user);
                    Session.Add("User", user);
                    Response.Redirect("default.aspx", false);

                }
                else
                {
                    Session.Add("Error", "Ususario o contraseña incorrectos, vuelve a intentarlo");
                    Response.Redirect("Error.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}