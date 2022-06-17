using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ad = ("Eren");
            MessageBox.Show(Ad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yaş = 19;
            MessageBox.Show(yaş.ToString()); // messageBox sayıları göstermez o yuzden to string koyuyuruz
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean mezuniyet = false;
            MessageBox.Show(mezuniyet.ToString()); //messageBox boolean göstermez o yuzden to string koyuyuruz
            MessageBox.Show("Şu an mezun değilim");
        }
    }
}
