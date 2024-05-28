using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TpFinal
{
    public partial class Error : System.Web.UI.Page
    {
        public bool reintentar { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            reintentar = false;
            if (Session["Message"] != null)
            {
                reintentar = false;
                lblError.Text = Session["Message"].ToString();
                Session.Remove("Message");
            }
            
            if (Session["Error"] != null)
            {
                lblError.Text = Session["Error"].ToString();
                reintentar = true;
                Session.Remove("Error");
            }
            
        }

        protected void btnReintentar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false);
        }
    }
}