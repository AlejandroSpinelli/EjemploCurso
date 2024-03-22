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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        public void mostrarimagen(string imagen)
        {
            try
            {
                pbxabout.Load(imagen);
            }
            catch (Exception)
            {
                pbxabout.Load("https://i.postimg.cc/9fqz2Z81/maxi-imagen.png");

            }
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

            mostrarimagen("https://static.wikia.nocookie.net/omniversal-battlefield/images/5/52/Tori_bot.png/revision/latest?cb=20180821004240");
        }
    }
}
