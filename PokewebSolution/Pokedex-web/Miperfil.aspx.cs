﻿using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_web
{
    public partial class Miperfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Trainee trainee = (Trainee)Session["Trainee"] != null ? (Trainee)Session["Trainee"] : null;

            if (!(IsPostBack))
            {
                if (!(Seguridad.SessionActiva(Session["Trainee"])))
                {
                    Response.Redirect("Default.aspx", false);
                }
                else
                {
                    Trainee user = ((Trainee)Session["Trainee"]);
                    if (user.nombre != null || user.nombre != "")
                    {
                        txbNombre.Text = user.nombre;
                    }
                    if (user.apellido != null || user.nombre != "")
                    {
                        txbApellido.Text = user.apellido;
                    }
                    if (string.IsNullOrEmpty(user.urlImagen))
                    {
                        imgPerfil.ImageUrl= "~/Images/" + user.urlImagen;
                    }
                    if (user.fechaNacimiento != null)
                    {
                        txbFechanacimiento.Text = user.fechaNacimiento.ToString("dd-mm-yyyy");
                    }
                    txbEmail.Text = user.mail;
                    txbEmail.Enabled = false;
                }
            }
            

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //escribir img
                TraineeNegocio negocio = new TraineeNegocio();
                
                Trainee user = (Trainee)Session["Trainee"];

                if(txtImg.PostedFile.FileName != "")
                {
                    string ruta = Server.MapPath("./Images/");
                    txtImg.PostedFile.SaveAs(ruta + "IMGPerfil-" + user.id + ".jpg");
                    user.urlImagen = "IMGPerfil-" + user.id + ".jpg";
                }
                

                user.nombre = txbNombre.Text;
                user.apellido = txbApellido.Text;
                user.fechaNacimiento=DateTime.Parse(txbFechanacimiento.Text);
                negocio.actualizar(user);

                //leer img
                Image img = (Image)Master.FindControl("ImgAvatar");
                img.ImageUrl = "~/Images/" + user.urlImagen;
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
            }
        }
    }
}