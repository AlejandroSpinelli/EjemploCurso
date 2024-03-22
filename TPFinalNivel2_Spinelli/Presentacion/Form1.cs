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
        public Form1()
        {
            InitializeComponent();
            Text = "Bienvenido al inventario";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarimagen("https://images.vexels.com/media/users/3/192451/isolated/preview/67723f2e9e8ed6b6a1818e2155793132-bolsas-de-compras-de-invierno-planas.png");
        }

        public void mostrarimagen(string imagen)
        {
            try
            {
                pbxImagenmain.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenmain.Load("https://i.postimg.cc/9fqz2Z81/maxi-imagen.png");

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            frmIngreso ingreso = new frmIngreso();
            ingreso.ShowDialog();
            Close();
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            
            frmRegistro registro = new frmRegistro();
            registro.ShowDialog();
            
        }
    }
}
