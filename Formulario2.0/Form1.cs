using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Formulario2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crearPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(VentanaPerfil))
                {
                    return;
                }
            }
           VentanaPerfil ventanaPerfil = new VentanaPerfil();
            ventanaPerfil.ShowDialog();
        }

        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vayuda ventanaver = new Vayuda();
            ventanaver.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void necesitoAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vayuda vayuda = new Vayuda();
            vayuda.ShowDialog();
        }
    }
}
