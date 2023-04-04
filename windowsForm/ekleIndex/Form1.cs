using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string secilen in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(secilen);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++) 
            {
                listBox2.Items.Add(checkedListBox1.CheckedIndices[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
