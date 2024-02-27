using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Disqueria
{
    public partial class frmAgregarDisco : Form
    {
        private Discos disco = null;
        private OpenFileDialog fileDialog = null;
        public frmAgregarDisco()
        {
            InitializeComponent();
        }

        public frmAgregarDisco(Discos Disco)
        {
            InitializeComponent();
            this.disco = Disco;
            Text = "Modificar Disco";
        }

        private void frmAgregarDisco_Load(object sender, EventArgs e)
        {
            
            try
            {

                EstiloNegocio negocio = new EstiloNegocio();
                TipoEdicionNegocio negocio2 = new TipoEdicionNegocio();
                cbxEstilo.DataSource = negocio.Listar();
                cbxEstilo.ValueMember = "Id";
                cbxEstilo.DisplayMember = "Descripcion";
                cbxFormato.DataSource = negocio2.Listar();
                cbxFormato.ValueMember = "Id";
                cbxFormato.DisplayMember = "Descripcion";


                if (disco != null)
                {

                    txbTitulo.Text = disco.Titulo;
                    dtpFecha.Value = disco.FechaLanzamiento;
                    txbCanciones.Text = disco.CantidadCanciones.ToString();
                    txbUrl.Text = disco.UrlImagenTapa;
                    mostrarimagen(txbUrl.Text);
                    cbxEstilo.SelectedValue = disco.Estilo.id;
                    cbxFormato.SelectedValue = disco.Edicion.id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void mostrarimagen(string imagen)
        {
            try
            {
                pbxAgregarDisco.Load(imagen);
            }
            catch (Exception)
            {

                pbxAgregarDisco.Load("https://png.pngtree.com/png-vector/20210609/ourmid/pngtree-mountain-network-placeholder-png-image_3423368.jpg");
            }
        }

        private void txbUrl_Leave(object sender, EventArgs e)
        {
            mostrarimagen(txbUrl.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.disco == null)
                    this.disco = new Discos();

                DiscosNegocio negocio = new DiscosNegocio();

                disco.Titulo = txbTitulo.Text;
                disco.FechaLanzamiento = dtpFecha.Value;
                disco.CantidadCanciones = int.Parse(txbCanciones.Text);
                disco.UrlImagenTapa = txbUrl.Text;
                disco.Estilo = (Estilos)cbxEstilo.SelectedItem;
                disco.Edicion = (TipoEdicion)cbxFormato.SelectedItem;

                if (disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Disco Modificado!");
                    this.Close();
                }
                else
                {
                    negocio.cargar(disco);
                    MessageBox.Show("Disco Agregado!");
                    this.Close();
                }

                if (fileDialog != null && !(txbUrl.Text.ToUpper().Contains("http:\\".ToUpper())))
                {
                    File.Copy(fileDialog.FileName, ConfigurationManager.AppSettings["carpeta-imagenes"] + fileDialog.SafeFileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarimg_Click(object sender, EventArgs e)
        {
            
            fileDialog =new OpenFileDialog();
            fileDialog.Filter = "PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|GIF (*.gif)|*.gif|BMP (*.bmp)|*.bmp|Todos los archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txbUrl.Text = fileDialog.FileName;
                mostrarimagen(fileDialog.FileName);
                //

            }
        }
    }
}
