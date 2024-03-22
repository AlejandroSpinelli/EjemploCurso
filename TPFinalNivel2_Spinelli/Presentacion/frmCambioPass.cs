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
    public partial class frmCambioPass : Form
    {
        bool banderapass = false;
        bool banderanuevas = false;
        bool banderavalidar = false;
        UserLog user = null;
        public frmCambioPass(UserLog usuario)
        {
            InitializeComponent();
            this.user = usuario;
        }

        private void tbxActual_Leave(object sender, EventArgs e)
        {
            Verificar();
            if (Verificar() == false)
            {
                lblErrorActual.Visible = true;
            }
            else
            {
                lblErrorActual.Visible=false;
                banderapass = true;
            }
        }

        private void tbxRepita_TextChanged(object sender, EventArgs e)
        {
            if (tbxRepita.Text != tbxNueva.Text)
            {
                lblErrorNueva.Visible = true;
                return;
            }
            lblErrorNueva.Visible = false;
            banderanuevas=true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (banderapass == true && banderanuevas == true && banderavalidar == true )
            {
                LoginNegocio negocio = new LoginNegocio();
                negocio.CambiarContraseña(user, tbxRepita.Text);
                MessageBox.Show("Contraseña cambiada!");
                Close();
            }
        }

        public bool Verificar()
        {
            LoginNegocio negocio = new LoginNegocio();
            bool respuesta= negocio.VerificarPass(user, tbxActual.Text);

            if(respuesta == true )
            {
                return true;
            }
            return false;
        }

        private void cbmostrar1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmostrar1.Checked)
            {
                tbxActual.UseSystemPasswordChar = false;
            }
            else
            {
                tbxActual.UseSystemPasswordChar = true;
            }
            
        }

        private void cbmostrar2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmostrar2.Checked)
            {
                tbxNueva.UseSystemPasswordChar = false;
            }
            else
            {
                tbxNueva.UseSystemPasswordChar = true;
            }

        }

        private void cbmostrar3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmostrar3.Checked)
            {
                tbxRepita.UseSystemPasswordChar = false;
            }
            else
            {
                tbxRepita.UseSystemPasswordChar = true;
            }
        }

        

        private void tbxNueva_Leave(object sender, EventArgs e)
        {
            if (tbxNueva.Text.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener entre 4 y 20 caracteres!");
                banderavalidar=false;
                return;

            }
            else if (tbxNueva.Text.Length > 20)
            {
                MessageBox.Show("La contraseña debe tener menos de 20 caracteres!");
                banderavalidar=false;
                return;
            }

            banderavalidar=true;
        }
    }
}
