using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;

namespace Presentacion
{
    public partial class frmRegistro : Form
    {
        private OpenFileDialog Dialog = null;
        public frmRegistro()
        {
            InitializeComponent();
            Text = "Registro";
        }

        public void mostrarimagen(string imagen)
        {
            try
            {
                pbxRegistro.Load(imagen);
            }
            catch (Exception)
            {
                pbxRegistro.Load("https://i.postimg.cc/9fqz2Z81/maxi-imagen.png");

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            mostrarimagen(tbxUrl.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LoginNegocio negocio = new LoginNegocio();
            UserLog usuario = new UserLog();

            if (validar())
            {
                return;
            }


            usuario.Nombre= tbxNombre.Text;
            usuario.Apellido= tbxApellido.Text;
            usuario.Email= tbxMail.Text;
            usuario.Contraseña= tbxContraseña.Text;
            usuario.UrlImagenPerfil= tbxUrl.Text;

            

            if (rbAdministrador.Checked)
            {
               
                usuario.Admin = true;
            }
            else
            {
                usuario.Admin = false;
            }

            string email = tbxMail.Text;

            bool respuesta = negocio.verificarmail(email);

            if (respuesta)
            {
                MessageBox.Show("Correo electronico en uso, por favor ingrese otro!");
                return;
            }


            negocio.registrar(usuario);
            MessageBox.Show("Usuario creado correctamente!");
            this.Close();

            if (Dialog != null && !(tbxUrl.Text.ToUpper().Contains("http:\\".ToUpper())))
            {
                string destino = ConfigurationManager.AppSettings["Imagenes"] + Dialog.SafeFileName;

                if (!File.Exists(destino))
                {
                    File.Copy(Dialog.FileName, destino);
                }
                
            }

        }

        private bool validar()
        {
            if (tbxMail.Text.Length < 1)
            {
                MessageBox.Show("Ingrese un Mail válido");
                return true;
            }else if (!(tbxMail.Text.Contains("@")))
            {
                MessageBox.Show("Ingrese un Mail válido");
                return true;
            }
            else if (!(tbxMail.Text.Contains(".")))
            {
                MessageBox.Show("Ingrese un Mail válido");
                return true;
            }

            if (tbxContraseña.Text.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener entre 4 y 20 caracteres!");
                return true;

            }
            else if (tbxContraseña.Text.Length > 20)
            {
                MessageBox.Show("La contraseña debe tener menos de 20 caracteres!");
                return true;
            }


            return false;
        }

        private void cbContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cbContraseña.Checked)
            {
                tbxContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                tbxContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxMail_Leave(object sender, EventArgs e)
        {
           LoginNegocio negocio = new LoginNegocio();
           string email=tbxMail.Text;

           bool respuesta= negocio.verificarmail(email);

           if (respuesta)
            {
                MessageBox.Show("Correo electronico en uso, por favor ingrese otro!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dialog = new OpenFileDialog();
            Dialog.Filter = "PNG (*.Png)|*.png|JPG (*.JPG)|*.jpg;*.jpeg|GIF (*.Gif)|*.gif|BMP (*.bmp)|*.bmp|Todos los archivos|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                tbxUrl.Text = Dialog.FileName;
                mostrarimagen(Dialog.FileName);
            }
        }

        private void rbAdministrador_Click(object sender, EventArgs e)
        {
            LoginNegocio negocio = new LoginNegocio();
            frmVerificarAdmin admin = new frmVerificarAdmin();
            admin.ShowDialog();

            string respuesta = admin.Resultado;



            bool alfa = negocio.VerificarPassAdmin(respuesta);


            if (alfa)
            {
                rbAdministrador.Checked = true;
            }
            else
            {
                rbAdministrador.Checked = false;

            }
        }
    }
}
