using Dominio;
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
    public partial class frmDetalles : Form
    {
        Articulo articulo = null;
        public frmDetalles(Articulo articulo)
        {
            InitializeComponent();
            Text = "Detalles";
            this.articulo = articulo;
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            mostrarimagen(articulo.UrlImagen);
        }

        public void mostrarimagen(string imagen)
        {
            try
            {
                pbxDetalles.Load(imagen);
            }
            catch (Exception)
            {
                pbxDetalles.Load("https://i.postimg.cc/9fqz2Z81/maxi-imagen.png");

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
