using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string str;
            if (checkBox2.Checked)
            {
                str = checkBox2.Text;
            }
            MessageBox.Show("Doğru cevabı seçtiniz...");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string str;
            if (checkBox1.Checked)
            {
                str = checkBox1.Text;
            }
            MessageBox.Show("Yanlış cevabı seçtiniz...");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string str;
            if (checkBox3.Checked)
            {
                str = checkBox3.Text;
            }
            MessageBox.Show("Yanlış cevabı seçtiniz...");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string str;
            if (checkBox4.Checked)
            {
                str = checkBox4.Text;
            }
            MessageBox.Show("Yanlış cevabı seçtiniz...");
        }
    
    
    }
}
