using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
            Text = "Bienvenido";
        }

        private void chbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrar.Checked)
            {
                txbContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txbContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LoginNegocio negocio = new LoginNegocio();

            string Email = txbUser.Text;
            string Contraseña = txbContraseña.Text;
            UserLog Usu = new UserLog();
            Usu=negocio.ingresar(Email,Contraseña);

            if (Usu.Email == txbUser.Text && Usu.Contraseña == txbContraseña.Text && Usu.Admin == false)
            {
                lblerror.Visible = false;
                prueba nuevo = new prueba(Usu);
                nuevo.ShowDialog();
            }
            else
            {
                lblerror.Visible = true;
            }

            if (Usu.Email == txbUser.Text && Usu.Contraseña == txbContraseña.Text && Usu.Admin == true)
            {
                bool acceso = true;
                lblerror.Visible = false;
                prueba nuevo = new prueba(acceso,Usu);
                nuevo.ShowDialog();
            }
            else
            {
                lblerror.Visible = true;
            }

            Close();
        }

        private void txbUser_Leave(object sender, EventArgs e)
        {
            try
            {
                LoginNegocio negocio = new LoginNegocio();

                string Email = txbUser.Text;

                UserLog Usu = new UserLog();
                Usu = negocio.traerimagen(Email);

                if (Usu.Email == txbUser.Text)
                {
                    pbxback.Visible = false;
                    pbxfront.Visible = true;
                    mostrarimagen2(Usu.UrlImagenPerfil);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {
            mostrarimagen("https://images.vexels.com/media/users/3/192451/isolated/preview/67723f2e9e8ed6b6a1818e2155793132-bolsas-de-compras-de-invierno-planas.png");
        }


        public void mostrarimagen(string imagen)
        {
            try
            {
                pbxback.Load(imagen);
            }
            catch (Exception)
            {
                pbxback.Load("https://i.postimg.cc/9fqz2Z81/maxi-imagen.png");

            }
        }


        public void mostrarimagen2(string imagen)
        {
            try
            {
                pbxfront.Load(imagen);
            }
            catch (Exception)
            {
                pbxfront.Load("https://images.vexels.com/media/users/3/192451/isolated/preview/67723f2e9e8ed6b6a1818e2155793132-bolsas-de-compras-de-invierno-planas.png");

            }
        }

    }
}
