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
            Usuario user = (Usuario)Session["Usuario"];
            if (user != null)
            {
                txbbuser.Enabled = false;
                txbPass.Enabled = false;
                btnIngresar.Text = "Desloguearse";
            }
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
            UsuarioNegocio negocio = new UsuarioNegocio();
            Usuario usuario;
            Usuario user = (Usuario)Session["Usuario"];

            try
            {
                
                if (user != null)
                {
                    Session.Remove("Usuario");
                    Response.Redirect("Default.aspx", false);

                }
                else
                {
                    usuario = new Usuario(txbbuser.Text, txbPass.Text, false);
                    if (negocio.Login(usuario))
                    {
                        Session.Add("Usuario", usuario);
                        Response.Redirect("Pagina 1.aspx", false);
                    }
                    else
                    {
                        Session.Add("Error", "User o Pass Incorrecto");
                        Response.Redirect("Error.aspx", false);
                    }
                }


            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }
            
        }
    }
}
