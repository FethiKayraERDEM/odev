using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpim, fark;
            sayi1 = Convert.ToInt16(textBox1.Text); 
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2;
            carpim = sayi1 * sayi2;
            fark = sayi1 - sayi2;
            label5.Text = toplam.ToString("0.000");
        
            MessageBox.Show("Toplam: " + toplam + "\n");





        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, carpim;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            carpim = sayi1 * sayi2;
            label4.Text = carpim.ToString("0.000");
            MessageBox.Show("Çarpım:" + carpim + "\n");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, fark;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            fark = sayi1 - sayi2;
            label3.Text = fark.ToString("0.000");
            MessageBox.Show("Fark:" + fark + "\n");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2,bolum;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            bolum = sayi1 / sayi2;
            label2.Text = bolum.ToString("0.000");
            MessageBox.Show("Bölüm:" + bolum + "\n");

        }
    }
}
