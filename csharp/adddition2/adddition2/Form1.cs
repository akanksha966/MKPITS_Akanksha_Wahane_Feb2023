using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adddition2
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
            int result=num1+num2;
            label3.Text = "addition is" + result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int result = num1 - num2;
            label3.Text = "substraction is" + result;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int result = num1 * num2;
            label3.Text = "multiplication" + result;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int result = num1 / num2;
            label3.Text = "division is" + result;
        }
    }
}
