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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Menu = new Form4();
            Menu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su Prestamo Fue de 1,000,000$" +
                " Por su 1 año del 27% de interes el total es: 270,000$ " + " Su deuda Total seria de: 1,270,000$");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su Prestamo Fue de 1,000,000$" +
                " Por su 2 año del 27% de interes el total es: 540,000$ " + " Su deuda Total seria de: 1,540,000$");
        }
    }
}
