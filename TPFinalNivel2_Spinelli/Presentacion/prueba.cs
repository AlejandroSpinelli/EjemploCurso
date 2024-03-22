using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class prueba : Form
    {
        UserLog Usuario = null;
        UserLog Administrador = null;
        

        List<Articulo> Articulo = null;
        public prueba(UserLog usuario)
        {
            InitializeComponent();
            Text = "Bienvenido/a " + usuario.Nombre.ToString();
            gbUsuario.Visible = true;
            this.Usuario = usuario;
           
        }

        public prueba(bool orden,UserLog usuario)
        {
            InitializeComponent();
            Text = "Catálogo para Administrador";
            if (orden == true)
            {
                gbAdmin.Visible = true;
            }
            this.Administrador=usuario;
            
        }

        private void prueba_Load(object sender, EventArgs e)
        {
            Cargar();
            Cargarcampo();
        }

        public void Cargarcampo()
        {
            cbxCampo.Items.Add("Precio");
            cbxCampo.Items.Add("Codigo");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripcion");
            cbxCampo.Items.Add("Categoria");
            cbxCampo.Items.Add("Marca");
        }

        public void Cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo = negocio.listar();
            dgvArticulos.DataSource = Articulo;
            mostrarimagen(Articulo[0].UrlImagen);
            Ocultar();

        }

        public void Ocultar()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["IdCategoria"].Visible = false;
            dgvArticulos.Columns["IdMArca"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        public void mostrarimagen(string imagen)
        {
            try
            {
                pbxImagenArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenArticulo.Load("https://i.postimg.cc/9fqz2Z81/maxi-imagen.png");

            }
        }

        private bool validarcampo()
        {
            if (cbxCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione uno de los campos!");
                return true;
            }

            if (cbxCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un criterio!");
                return true;
            }

            if (cbxCampo.SelectedItem.ToString() == "Precio")
                if (string.IsNullOrEmpty(txbFiltroAvanzado.Text))
                {
                    MessageBox.Show("Ingrese un precio!");
                    return true;
                }

            if (cbxCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(solonumeros(txbFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Ingrese solo números para precios!");
                    return true;
                }
            }

            return false;
        }


        private bool solonumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }


        private void txbFiltroRapido_TextChanged_1(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            string filtro = txbFiltroRapido.Text;

            if (filtro != " ")
            {
                listafiltrada = Articulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listafiltrada = Articulo;
            }

            dgvArticulos.DataSource = listafiltrada;
            Ocultar();
        }

        private void btnBusqueda_Click_1(object sender, EventArgs e)
        {
            if (gbfiltroavanzado.Visible == false)
            {
                gbfiltroavanzado.Visible = true;

            }
            else
            {

                gbfiltroavanzado.Visible = false;

            }
        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.ShowDialog();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (validarcampo())
                return;


            ArticulosNegocio negocio = new ArticulosNegocio();
            string campo = cbxCampo.SelectedItem.ToString();
            string criterio = cbxCriterio.SelectedItem.ToString();
            string filtro = txbFiltroAvanzado.Text;

            dgvArticulos.DataSource = negocio.filtroavanzado(campo, criterio, filtro);
        }

        private void cbxCampo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string seleccionado = cbxCampo.SelectedItem.ToString();

            if (seleccionado == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            DialogResult respuesta = MessageBox.Show("Desea Eliminar definitivamente el articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                negocio.EliminarFisico(seleccionado);
                MessageBox.Show("Articulo Eliminado!");
                Cargar();
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FrmCarga carga = new FrmCarga(seleccionado);
            carga.ShowDialog();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            FrmCarga carga = new FrmCarga();
            carga.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged_1(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            mostrarimagen(seleccionado.UrlImagen);
        }

        private void btnAgregarFavoritos_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo articulo = new Articulo();
            articulo=(Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int id;
            if (Usuario != null)
            {
                id = Usuario.Id;
            }
            else
            {
                id= Administrador.Id;
            }

            negocio.CargarFavorito(articulo,id);
            MessageBox.Show("Articulo agregado a tus favoritos");
        }

        private void btnMisFavoritos_Click(object sender, EventArgs e)
        {
            
            UserLog user;
            if (Usuario != null)
            {
                user= Usuario;
            }
            else
            {
                user = Administrador;
            }
            frmMisFav favoritos = new frmMisFav(user);
            favoritos.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            
            
                frmPerfil perfil = new frmPerfil(Usuario);
                perfil.ShowDialog();
            
        }

        public void Detalles()
        {
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalles detalles = new frmDetalles(articulo);
            detalles.ShowDialog();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Detalles();
        }

        private void btnDetalles2_Click(object sender, EventArgs e)
        {
            Detalles();
        }
    }
}
