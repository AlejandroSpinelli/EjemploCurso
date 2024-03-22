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
using System.IO;
using System.Configuration;

namespace Presentacion
{
    public partial class FrmCarga : Form
    {
        private Articulo articulo=null;
        private OpenFileDialog Dialog=null;
        public FrmCarga()
        {
            InitializeComponent();
            Text = "Cargar artículo";
            
        }

        public FrmCarga(Articulo articulo)
        {
            InitializeComponent();
            Text = "Modificar artículo";
            this.articulo = articulo;
        }

        private void FrmCarga_Load(object sender, EventArgs e)
        {
            cargarcbx();
        }

        public void cargarcbx()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            MarcaNegocio negocio2 = new MarcaNegocio();
            cbxCategoria.DataSource=(negocio.listar());
            cbxMarca.DataSource=(negocio2.listar());
            cbxCategoria.ValueMember = "Id";
            cbxCategoria.DisplayMember = "Descripcion";
            cbxMarca.ValueMember = "Id";
            cbxMarca.DisplayMember = "Descripcion";

            if (articulo != null)
            {
                txbCodigo.Text = articulo.Codigo;
                txbNombre.Text = articulo.Nombre;
                txbDescripcion.Text = articulo.Descripcion;
                txbUrl.Text = articulo.UrlImagen;
                mostrarimagen(txbUrl.Text);
                cbxCategoria.SelectedItem = articulo.categoria.Id;
                cbxMarca.SelectedItem = articulo.marca.Id;
                txbPrecio.Text = articulo.Precio.ToString();
  
            }
        }

        public void mostrarimagen(string imagen)
        {
            try
            {
                pbxCarga.Load(imagen);
            }
            catch (Exception)
            {
                pbxCarga.Load("https://i.postimg.cc/9fqz2Z81/maxi-imagen.png");

            }
        }

        private void txbUrl_Leave(object sender, EventArgs e)
        {
            mostrarimagen(txbUrl.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
                return;

            if (articulo == null)
                this.articulo = new Articulo();

            articulo.Codigo = txbCodigo.Text;
            articulo.Nombre = txbNombre.Text;
            articulo.Descripcion = txbDescripcion.Text;
            articulo.UrlImagen = txbUrl.Text;
            articulo.categoria = (Categoria)cbxCategoria.SelectedItem;
            articulo.marca = (Marca)cbxMarca.SelectedItem;
            articulo.Precio = decimal.Parse(txbPrecio.Text);

            if (txbPrecio.Text.Contains("."))
                
                {
                    MessageBox.Show("Ingrese un precio!");
                    
                }

            if (!(solonumeros(txbPrecio.Text)))
            {
                MessageBox.Show("Ingrese solo números para precios y sin puntos!");
              
            }




            if (articulo.Id != 0)
            {
                modificar(articulo);
                MessageBox.Show("Articulo modificado!");
                this.Close();
            }
            else
            {
                cargararticulo(articulo);
                MessageBox.Show("Articulo agregado!");
                this.Close();
            }

            if (Dialog != null && !(txbUrl.Text.ToUpper().Contains("http:\\".ToUpper())))
            {
                File.Copy(Dialog.FileName, ConfigurationManager.AppSettings["Imagenes"] + Dialog.SafeFileName);
            }

            
        }
        public void modificar(Articulo articulo)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            negocio.Modificar(articulo);
        }
        public void cargararticulo(Articulo articulo)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo articulito = articulo;
            negocio.Cargar(articulito);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
          Dialog=new OpenFileDialog();
          Dialog.Filter = "PNG (*.Png)|*.png|JPG (*.JPG)|*.jpg;*.jpeg|GIF (*.Gif)|*.gif|BMP (*.bmp)|*.bmp|Todos los archivos|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
          if (Dialog.ShowDialog() == DialogResult.OK)
            {
                txbUrl.Text =Dialog.FileName;
                mostrarimagen(Dialog.FileName);
            }
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


        public bool validar()
        {
           if(txbPrecio.Text == "")
            if (string.IsNullOrEmpty(txbPrecio.Text))
                {
                    MessageBox.Show("Ingrese un precio!");
                    return true;
                }

            if (!(solonumeros(txbPrecio.Text)))
            {
                MessageBox.Show("Ingrese solo números para precios!");
                return true;
            }

            return false;
        }


    }
}
