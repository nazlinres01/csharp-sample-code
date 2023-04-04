using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = " ";
            if(checkBox1.Checked)
            {
                str = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                if(str==" ")
                {
                    str = checkBox2.Text;
                }
                else
                {
                    str+=","+checkBox2.Text;

                }
                
            }
            if (checkBox3.Checked)
            {
                if(str==" ")
                {
                    str= checkBox3.Text;
                }
                else
                { 
                    str += ","+checkBox3.Text;
                }
                
            }
            MessageBox.Show(str);


        }
    }
}
