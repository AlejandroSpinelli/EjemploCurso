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


namespace Disqueria
{
    public partial class FrmCatalogoDiscos : Form
    {
        List<Discos> disco;
        public FrmCatalogoDiscos()
        {
            InitializeComponent();
            Text = "Catálogo";
        }

        private void FrmCatalogoDiscos_Load(object sender, EventArgs e)
        {
            cargardgv();
            cbxCampo.Items.Add("Cantidad de Canciones");
            cbxCampo.Items.Add("Título");
        }
        private void ocultarcolumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }
        private void mostrarimagen(string imagen)
        {
            try
            {
                pbxPrincipal.Load(imagen);
            }
            catch (Exception)
            {

                pbxPrincipal.Load("https://png.pngtree.com/png-vector/20210609/ourmid/pngtree-mountain-network-placeholder-png-image_3423368.jpg");
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDiscos.DataSource != null)
            {
               Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
               mostrarimagen(seleccionado.UrlImagenTapa);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarDisco agregar = new frmAgregarDisco();
            agregar.ShowDialog();
        }

        public void cargardgv()
        {
            DiscosNegocio negocio = new DiscosNegocio();
            disco = negocio.listar();
            dgvDiscos.DataSource = disco;
            ocultarcolumnas();
            mostrarimagen(disco[0].UrlImagenTapa);
        }

        private void btnELiminarfisico_Click(object sender, EventArgs e)
        {
            
            Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            DiscosNegocio negocio=new DiscosNegocio();
            DialogResult respuesta = MessageBox.Show("Desea eliminar el Disco seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respuesta == DialogResult.Yes)
            negocio.eliminar(seleccionado.Id);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Discos seleccionado;
            seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            frmAgregarDisco modificar = new frmAgregarDisco(seleccionado);
            modificar.ShowDialog();
        }

        private void txbFIltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Discos> listafiltrada;
            string filtro= txbFIltroRapido.Text;

            if (filtro != "")//(filtro.Length >= 3)
            {
                
                listafiltrada= disco.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()));
              
            }
            else
            {
                listafiltrada = disco;
            }
            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listafiltrada;
            ocultarcolumnas();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion=cbxCampo.SelectedItem.ToString();

            if (opcion == "Cantidad de Canciones")
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if (validarfiltro())
                    return;
                string Campo = cbxCampo.SelectedItem.ToString();
                string Criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txbFiltro.Text;
                

                dgvDiscos.DataSource = negocio.filtrar(Campo, Criterio, filtro);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private bool validarfiltro()
        {
            if(cbxCampo.SelectedIndex == -1) 
            {
                MessageBox.Show("El campo debe estar seleccionado!");
                return true;
            }

            if (cbxCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("El criterio debe estar seleccionado!");
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "Cantidad de Canciones")
            {
                if (string.IsNullOrEmpty(txbFiltro.Text))
                    MessageBox.Show("Debes cargar el filtro para numericos");
                if (!(solonumeros(txbFiltro.Text)))
                {
                    MessageBox.Show("Ingrese solo numeros en este campo numerico!");
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
            
        }
    }
}
