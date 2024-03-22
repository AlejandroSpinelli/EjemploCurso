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
    public partial class frmMisFav : Form
    {
        List<Articulo> Articulo = null;
        UserLog Usuario = null;
        public frmMisFav()
        {
            InitializeComponent();
        }

        public frmMisFav(UserLog usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            Text="Favoritos de " + usuario.Nombre.ToString();
        }

        private void frmMisFav_Load(object sender, EventArgs e)
        {
            
          Cargar();

        }

        public void Cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo = negocio.MostrarFavoritos(Usuario.Id);

            
            if (Articulo != null && Articulo.Count > 0)
            {
                dgvFavoritos.DataSource = Articulo;

                if (!(DBNull.Value.Equals(Articulo[0].UrlImagen)))
                {
                    mostrarimagen(Articulo[0].UrlImagen);
                }

                Ocultar();
            }
            else
            {
                MessageBox.Show("Aún no hay favoritos cargados!");
                Close();
                return;
                
            }


        }

        public void mostrarimagen(string imagen)
        {
            try
            {
                pbxFav.Load(imagen);
            }
            catch (Exception)
            {
                pbxFav.Load("https://i.postimg.cc/9fqz2Z81/maxi-imagen.png");

            }
        }

        public void Ocultar()
        {
            dgvFavoritos.Columns["UrlImagen"].Visible = false;
            dgvFavoritos.Columns["IdCategoria"].Visible = false;
            dgvFavoritos.Columns["IdMArca"].Visible = false;
            dgvFavoritos.Columns["Id"].Visible = false;
        }

        private void dgvFavoritos_SelectionChanged(object sender, EventArgs e)
        {

                Articulo seleccionado = (Articulo)dgvFavoritos.CurrentRow.DataBoundItem;
                mostrarimagen(seleccionado.UrlImagen);

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvFavoritos.CurrentRow.DataBoundItem;
            ArticulosNegocio negocio=new ArticulosNegocio();

            DialogResult respuesta = MessageBox.Show("Desea quitar el artículo de favoritos?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                negocio.EliminarFavorito(seleccionado, Usuario);
                MessageBox.Show("Articulo Quitado!");
                Cargar();
            }





            
        }
    }

}
