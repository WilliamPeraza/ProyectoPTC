using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPTC
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox1(e);
            //Validar.espacio(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox1(e);
            //Validar.espacio(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox1(e);
            //Validar.espacio(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox1(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox1(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string y1 = textBox1.Text;
            int year = Convert.ToInt32(y1);

            string y2 = textBox6.Text;
            int year2 = Convert.ToInt32(y2);

            int finalage = year2 - year;
            int mesesvida = finalage * 12;
            int diasvida = finalage * 365;

            MessageBox.Show("Años con Vida: " + finalage + Environment.NewLine +
                            "Meses con vida: " + mesesvida + Environment.NewLine +
                            "Días con vida: " + diasvida);
            //************************************************
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox1(e);
        }
    }
}
