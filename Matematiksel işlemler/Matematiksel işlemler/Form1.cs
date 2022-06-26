using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematiksel_işlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sayi1 = Convert.ToInt32(textBox1.Text);
            int Sayi2 = Convert.ToInt32(textBox2.Text);

            int sonuc = Sayi1 + Sayi2;
            textBox3.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Sayi1 = Convert.ToInt32(textBox6.Text);
            int Sayi2 = Convert.ToInt32(textBox5.Text);

            int sonuc = Sayi1 - Sayi2;
            textBox4.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox9.Text);
            int sayi2 = Convert.ToInt32(textBox8.Text);

            int sonuc = sayi1 * sayi2;
            textBox7.Text = sonuc.ToString(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox12.Text); // int kullanmamamızın nedeni bölme işleminde küsüratı bize vermiyor olması
            double sayi2 = Convert.ToDouble(textBox11.Text); // bu yüzden double veri tipini kullanırız ki küsüratı versin

            double sonuc = sayi1 / sayi2;
            textBox10.Text = sonuc.ToString();
        }
    }
}
