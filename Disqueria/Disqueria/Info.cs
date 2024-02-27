using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disqueria
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            mostrarimagen("https://cdn-icons-png.flaticon.com/512/74/74717.png");
        }


        private void mostrarimagen(string imagen)
        {
            try
            {
                pbxFoto.Load(imagen);
            }
            catch (Exception)
            {

                pbxFoto.Load("https://png.pngtree.com/png-vector/20210609/ourmid/pngtree-mountain-network-placeholder-png-image_3423368.jpg");
            }
        }
    }


}
