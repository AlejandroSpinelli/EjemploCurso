using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario2._0
{
    public partial class VentanaPerfil : Form
    {
        public VentanaPerfil()
        {
            InitializeComponent();
        }


        private void VentanaPerfil_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Soltera/o");
            comboBox1.Items.Add("Casada/o");
            comboBox1.Items.Add("En pareja");
            comboBox1.Items.Add("Divorciada/o");
            comboBox1.Items.Add("Viuda/o");
            comboBox1.Items.Add("Es complicado");
        }

        private void textBoxnombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = textBoxnombre.Text;

        }

        private void textBoxapellido_TextChanged(object sender, EventArgs e)
        {
            string apellido = textBoxapellido.Text;
        }

        private void textBoxmail_TextChanged(object sender, EventArgs e)
        {
            string mail = textBoxmail.Text;
        }
        string sexo;
        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                sexo = "femenino";

            }
            else if (radioButton2.Checked)
            {
                sexo = "masculino";
            }
            else
                sexo = "";


            string ecivil = comboBox1.Text;

            listView1.Items.Add("Nombre: "+textBoxnombre.Text);
            listView1.Items.Add("Apellido: "+textBoxapellido.Text);
            listView1.Items.Add("Sexo: "+sexo);
            listView1.Items.Add("Fecha de nacimiento: " + dateTimePicker1.Value.ToString("dd/MM/yyy"));
            listView1.Items.Add("Estado civil: "+ comboBox1.Text);
            listView1.Items.Add("Email: "+textBoxmail.Text);
            

            
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            

            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }  
}
