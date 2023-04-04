using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = int.Parse(textBox1.Text);
            
            if(sayi<=0)
            {
                MessageBox.Show("lütfen pozitif bir sayı giriniz");
            }
            else
            {
                listBox1.Items.Add(sayi);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

            
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
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
            label2.Text = enBuyuk.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
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
            label4.Text = enKucuk.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                for (int j = i; j <= listBox1.Items.Count - 1; j++)
                    if (int.Parse(listBox1.Items[j].ToString()) > int.Parse(listBox1.Items[i].ToString()))
                    {
                        int sırala = int.Parse(listBox1.Items[i].ToString());
                        listBox1.Items[i] = listBox1.Items[j];
                        listBox1.Items[j] = sırala.ToString();
                    }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
                for (int j = i; j <= listBox1.Items.Count - 1; j++)
                    if (int.Parse(listBox1.Items[j].ToString()) < int.Parse(listBox1.Items[i].ToString()))
                    {
                        int sırala = int.Parse(listBox1.Items[i].ToString());
                        listBox1.Items[i] = listBox1.Items[j];
                        listBox1.Items[j] = sırala.ToString();
                    }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
