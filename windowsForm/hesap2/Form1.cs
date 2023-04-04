using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked)
            {

                int toplam = sayi1 + sayi2;
                label2.Text = " " + toplam;

            }
            if(radioButton2.Checked)
            {
                int cıkarma = sayi1 - sayi2;
                label2.Text = " " + cıkarma;
            }
            if(radioButton3.Checked)
            {
                int carpım = sayi1 * sayi2;
                label2.Text = " " + carpım;
            }
            if(radioButton4.Checked)
            {
                int bolme = sayi1 / sayi2;
                int kalan = sayi1 % sayi2;
                label2.Text = bolme + "  "+"kalan = " + kalan;
            }


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
