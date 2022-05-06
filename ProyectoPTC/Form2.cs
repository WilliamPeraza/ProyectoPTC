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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 paginaprincipal = new Form4();
            paginaprincipal.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox1(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox1(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.textBox1(e);
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
            string numero1 = textBox1.Text;
            int n1 = Convert.ToInt32(numero1);

            string numero2 = textBox2.Text;
            int n2 = Convert.ToInt32(numero2);

            string numero3 = textBox3.Text;
            int n3 = Convert.ToInt32(numero3);

            string numero4 = textBox4.Text;
            int n4 = Convert.ToInt32(numero4);

            string numero5 = textBox5.Text;
            int n5 = Convert.ToInt32(numero5);

            if (n1 >= n2 && n1 >= n3 && n1 >= n4 && n1 >= n5)
            {
                MessageBox.Show($"La cantidad {n1} es el número mayor");
            }
            else if (n2 >= n1 && n2 >= n3 && n2 >= n4 && n2 >= n5)
            {
                MessageBox.Show($"La cantidad {n2} es el número mayor");
            }
            else if (n3 >= n1 && n3 >= n2 && n3 >= n4 && n3 >= n5)
            {
                MessageBox.Show($"La cantidad {n3} es el número mayor");
            }
            else if (n4 >= n1 && n4 >= n2 && n4 >= n3 && n4 >= n5)
            {
                MessageBox.Show($"La cantidad {n4} es el número mayor");
            }
            else if (n5 >= n1 && n5 >= n2 && n5 >= n3 && n5 >= n4)
            {
                MessageBox.Show($"La cantidad {n5} es el número mayor");
            }



            if (n1 <= n2 && n1 <= n3 && n1 <= n4 && n1 <= n5)
            {
                MessageBox.Show($"La cantidad {n1} es el número mayor");
        }
            else if (n2 <= n1 && n2 <= n3 && n2 <= n4 && n2 <= n5)
            {
                MessageBox.Show($"La cantidad {n2} es el número mayor");
            }
            else if (n3 <= n1 && n3 <= n2 && n3 <= n4 && n3 <= n5)
            {
                MessageBox.Show($"La cantidad {n3} es el número mayor");
            }
            else if (n4 <= n1 && n4 <= n2 && n4 <= n3 && n4 <= n5)
            {
                MessageBox.Show($"La cantidad {n4} es el número mayor");
            }
            else if (n5 <= n1 && n5 <= n2 && n5 <= n3 && n5 <= n4)
            {
                MessageBox.Show($"La cantidad {n5} es el número mayor");
            }
        }
    }
}
