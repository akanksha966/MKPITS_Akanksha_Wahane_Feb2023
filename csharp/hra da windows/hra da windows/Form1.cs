using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hra_da_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            int basic;
            float hrsalary,dasalary,tsalary,total;
            name=Convert.ToString(textBox1.Text);
            basic = Convert.ToInt32(textBox2.Text);
            hrsalary = basic * 0.35f;
            label3.Text = ("hr total salary is " + hrsalary);

            dasalary = basic * 0.45f;
            label4.Text = ("da total salary is " + dasalary);

            tsalary=hrsalary+dasalary+basic;
            label5.Text = ("total salary is :" + tsalary);

        }
    }
}
