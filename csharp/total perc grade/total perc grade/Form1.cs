using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace total_perc_grade
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
            int num3=Convert.ToInt32(textBox3.Text);
            int add=num1+num2+num3;
            label4.Text = ("total is " + add);
            float per = add / 300f * 100;
            label5.Text = ("percent is :" + per);

            if (per >= 85)
            {
                label6.Text = ("grade is:distinction");
            }
            else if(per>=65)
            {
                label6.Text = ("grade is:first class");
            }
            else
            {
                label6.Text = ("grade is:fail");
            }
        }
    }
}
