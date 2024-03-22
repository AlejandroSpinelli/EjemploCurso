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
    public partial class frmPerfil : Form
    {
        UserLog user = null;
        bool bandera = false;
        public frmPerfil(UserLog usuario)
        {
            InitializeComponent();
            this.user = usuario;
            Text = "Mi perfil";
            
        }


        private void frmPerfil_Load(object sender, EventArgs e)
        {
            
                lblNombre2.Text = user.Nombre.ToString();
                lblApellido2.Text = user.Apellido.ToString();
                lblMail2.Text = user.Email.ToString();
                mostrarimagen(user.UrlImagenPerfil);
                bandera = true;
            
            

        }

        public void mostrarimagen(string imagen)
        {
            try
            {
                pbxPerfil.Load(imagen);
            }
            catch (Exception)
            {
                pbxPerfil.Load("https://i.postimg.cc/9fqz2Z81/maxi-imagen.png");

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmModificarPerfil perfil=new frmModificarPerfil(user);
            perfil.ShowDialog();
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Actualizar()
        {
            
            LoginNegocio negocio = new LoginNegocio();
            UserLog usuario = negocio.Actualizar(user);

            if (!(DBNull.Value.Equals(usuario.Nombre)))
            {
                lblNombre2.Text = usuario.Nombre;
            }

            if (!(DBNull.Value.Equals(usuario.Apellido)))
            {
                lblApellido2.Text = usuario.Apellido;
            }

            if (!(DBNull.Value.Equals(usuario.UrlImagenPerfil)))
            {
                mostrarimagen(usuario.UrlImagenPerfil);
            }

        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            frmCambioPass cambio = new frmCambioPass(user);
            cambio.ShowDialog();

        }
    }
}
