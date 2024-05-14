using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Pokedex_web
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void chbpass_CheckedChanged(object sender, EventArgs e)
        {
            if(chbpass.Checked)
            {
                
                txbPass.TextMode = TextBoxMode.SingleLine;
                
            }
            else if (chbpass.Checked==false)
            {
                
                txbPass.TextMode = TextBoxMode.Password;
               
            }
                
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            TraineeNegocio negocio = new TraineeNegocio();
            Trainee trainee = new Trainee();
            try
            {
                trainee.mail = txbbuser.Text;
                trainee.pass = txbPass.Text;

                if (negocio.Login(trainee))
                {
                    Session.Add("Trainee", trainee);
                    Response.Redirect("Miperfil.aspx", false);
                }
                else
                {
                    Session.Add("Error", "User o Pass incorrectos");
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
