using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windos_greater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(textBox1.Text);
            int num2=Convert.ToInt32(textBox2.Text);
            if(num1>num2)
            {
                label3.Text = ("num1 is greater no");

            }
            else
            {
                label3.Text = ("num2 is greater no");


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            if (num1 <num2 )
            {
                label3.Text = ("num1 is smaller");

            }
            else
            {
                label3.Text = ("num2 is smaller");


            }

        }
    }
    }

