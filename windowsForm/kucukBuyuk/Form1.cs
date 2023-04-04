using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int enKucuk = Convert.ToInt32(listBox1.Items[0]), sayi;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayi = Convert.ToInt32(listBox1.Items[i]);
                if (sayi < enKucuk)
                {
                    enKucuk = sayi;
                }
            }
            textBox1.Text = enKucuk.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int enBuyuk = Convert.ToInt32(listBox1.Items[0]), sayi;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayi = Convert.ToInt32(listBox1.Items[i]);
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            textBox1.Text = enBuyuk.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi;
                sayi = int.Parse(textBox1.Text);
                listBox1.Items.Add(sayi);
            }
            catch
            {
                MessageBox.Show("Lütfen sayı giriniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
