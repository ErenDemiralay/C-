using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Isimler = { "Eren", "Muhammed", "Hasan" };
            MessageBox.Show(Isimler[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Sehirler = new string[5];
            Sehirler[0] = "Eskişehir";
            Sehirler[1] = "Ankara";
            Sehirler[2] = "İstanbul";
            Sehirler[3] = "Bursa";
            Sehirler[4] = "Kütahya";
            MessageBox.Show(Sehirler[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5 };
            MessageBox.Show(sayilar[0].ToString());  //Message box sayı göstemediği için to string kullandık
        }

        //Array buraya kadardı Listlerin arraylardan farkı listenin içinde kaç elaman olacağını belirlemek
        private void button4_Click(object sender, EventArgs e)
        {
            List<String> Isimler = new List<String>();
            Isimler.Add("Eren");
            Isimler.Add("Muhammed");
            MessageBox.Show(Isimler[0]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> Sayilar = new List<int>();

            Sayilar.Add(1453);
            Sayilar.Add(1881);
            Sayilar.Add(1938);
            Sayilar.Add(5301);
            MessageBox.Show(Sayilar[2].ToString());
        }
    }
}