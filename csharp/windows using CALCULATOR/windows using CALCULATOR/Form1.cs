using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_using_CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        Calculator cal = new Calculator();

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.plusclick(Convert.ToInt32(textBox1.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";

        }



        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(cal.minusclick(Convert.ToInt32(textBox1.Text)));

        }




        private void button8_Click(object sender, EventArgs e)
        {
            int result = cal.calculateresult(Convert.ToInt32(textBox1.Text));
            textBox1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(cal.multclick(Convert.ToInt32(textBox1.Text)));
        }

        private void button7_Click(object sender, EventArgs e)
        {

            //textBox1.Text = Convert.ToString(cal.divisionclick(Convert.ToInt32(textBox1.Text)));
            textBox1.Text =  cal.divisionclick(Convert.ToInt32(textBox1.Text)).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
