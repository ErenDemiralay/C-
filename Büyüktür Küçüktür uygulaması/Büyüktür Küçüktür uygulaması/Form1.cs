using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Büyüktür_Küçüktür_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text );

            if (x < y)
            {
                MessageBox.Show("X Y'den küçük");
            }
            else if(x == y)
            {
                MessageBox.Show("X eşittir Y");
            }
            else
            {
                MessageBox.Show("X Y'den büyüktür");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox3.Text);
            switch (i)
            {
                case 10:
                    MessageBox.Show("yaşınız yeterli değil");
                    break;

                case 18:
                    MessageBox.Show("yaşınız yeterli");
                    break;
                default:
                    MessageBox.Show("Uygun yaş girmediniz");
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
