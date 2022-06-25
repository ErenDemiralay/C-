using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn_Giriş__Arayüzü_deneme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            MessageBox.Show("bilgiler kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            checkBox1.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            textBox1.MaxLength = 4;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
