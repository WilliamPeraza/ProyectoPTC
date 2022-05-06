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
            Validar.espacio(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox2(e);
            Validar.espacio(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox3(e);
            Validar.espacio(e);
        }
    }
}
