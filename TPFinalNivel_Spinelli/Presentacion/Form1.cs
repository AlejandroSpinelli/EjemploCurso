using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        List<Articulo> Articulo = null;
        public Form1()
        {
            InitializeComponent();
            Text = "Catálogo";
        }

        private void Form1_Load(object sender, EventArgs e)
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
            Articulo= negocio.listar();
            dgvArticulos.DataSource=Articulo;
            mostrarimagen(Articulo[0].UrlImagen);
            Ocultar();

        }

        public void Ocultar()
        {
            dgvArticulos.Columns["UrlImagen"].Visible=false;
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

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                mostrarimagen(seleccionado.UrlImagen);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCarga carga = new FrmCarga();
            carga.ShowDialog();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FrmCarga carga=new FrmCarga(seleccionado);
            carga.ShowDialog();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            
            DialogResult respuesta = MessageBox.Show("Desea Eliminar definitivamente el articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta==DialogResult.Yes)
            {
                negocio.EliminarFisico(seleccionado);
                MessageBox.Show("Articulo Eliminado!");
                Cargar();
            }
        }

        private void txbFiltroRapido_TextChanged(object sender, EventArgs e)
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

        private void btnBusqueda_Click(object sender, EventArgs e)
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarcampo())
                return;
            

                ArticulosNegocio negocio = new ArticulosNegocio();
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txbFiltroAvanzado.Text;

                dgvArticulos.DataSource = negocio.filtroavanzado(campo, criterio, filtro);
            
         
            

        }

        private bool validarcampo()
        {
            if(cbxCampo.SelectedIndex == -1 )
            {
                MessageBox.Show("Seleccione uno de los campos!");
                return true;
            }

            if (cbxCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un criterio!");
                return true;
            }

            if(cbxCampo.SelectedItem.ToString() == "Precio")
                if (string.IsNullOrEmpty(txbFiltroAvanzado.Text))
                {
                    MessageBox.Show("Ingrese un precio!");
                    return true;
                }

            if (!(solonumeros(txbFiltroAvanzado.Text)))
            {
                MessageBox.Show("Ingrese solo números para precios!");
                return true;
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.ShowDialog();
        }
    }
}
