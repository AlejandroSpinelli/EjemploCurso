using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpFinal
{
    public partial class Registro : System.Web.UI.Page
    {   public bool validoUser {  get; set; }
        public bool validoPass {  get; set; }
        public bool EsContraseñaValida(string contraseña)
        {

            string patron = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(contraseña, patron);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                validoUser = false;
                validoPass = false;
            }
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                LoginNegocio negocio = new LoginNegocio();
                UserLog user = new UserLog();
                if (txbEmail.Text.Contains("@") && txbEmail.Text.Contains(".com"))
                {
                    user.Email = txbEmail.Text;
                }
                else
                {
                    validoUser = true;
                    return;
                }

                if (txbPass.Text == txbPass2.Text && !string.IsNullOrEmpty(txbPass.Text) && EsContraseñaValida(txbPass.Text))
                {
                    user.Contraseña = txbPass.Text;
                }
                else
                {
                    validoPass = true;
                    return;
                }
                

                negocio.registrar(user);


                //Falta resolver el tema del correo electronico

                string message = "Usuario registrado con exito,logueate!";
                Session.Add("message", message);
                Response.Redirect("Error.aspx", false);
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx", false);
            }


            

        }
    }
}