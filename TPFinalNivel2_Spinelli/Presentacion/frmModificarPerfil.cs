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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;
using System.Configuration;


namespace Presentacion
{   
    
    public partial class frmModificarPerfil : Form
    {
        private OpenFileDialog Dialog = null;
        UserLog usuario = null;
        public frmModificarPerfil(UserLog user)
        {
            InitializeComponent();
            this.usuario = user;
            Text = "Modificando perfil";
        }

        private void frmModificarPerfil_Load(object sender, EventArgs e)
        {
            cargar();

        }

        public void mostrarimagen(string imagen)
        {
            try
            {
                pbxModificar.Load(imagen);
            }
            catch (Exception)
            {
                pbxModificar.Load("https://i.postimg.cc/9fqz2Z81/maxi-imagen.png");

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Nombre = tbxNombre.Text;
            string Apellido = tbxApellido.Text;
            string Url = tbxUrl.Text;

            LoginNegocio negocio = new LoginNegocio();

            negocio.Modificar(usuario, Nombre, Apellido, Url);
            MessageBox.Show("Perfíl actualizado,los cambios se veran efectuados en su próximo inicio de sesión!");

            if (Dialog != null && !(tbxUrl.Text.ToUpper().Contains("http:\\".ToUpper())))
            {
                string destino = ConfigurationManager.AppSettings["Imagenes"] + Dialog.SafeFileName;

                if (!File.Exists(destino))
                {
                    File.Copy(Dialog.FileName, destino);
                }
               
            }


            Close();
            
        }

        public void cargar()
        {
            tbxNombre.Text = usuario.Nombre;
            tbxApellido.Text = usuario.Apellido;
            tbxUrl.Text = usuario.UrlImagenPerfil;
            mostrarimagen(usuario.UrlImagenPerfil);
        }

        private void tbxUrl_TextChanged(object sender, EventArgs e)
        {
            mostrarimagen(tbxUrl.Text);
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            Dialog = new OpenFileDialog();
            Dialog.Filter = "PNG (*.Png)|*.png|JPG (*.JPG)|*.jpg;*.jpeg|GIF (*.Gif)|*.gif|BMP (*.bmp)|*.bmp|Todos los archivos|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                tbxUrl.Text = Dialog.FileName;
                mostrarimagen(Dialog.FileName);
            }
        }
    }
}
