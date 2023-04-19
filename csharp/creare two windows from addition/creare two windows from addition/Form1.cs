using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creare_two_windows_from_addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addition stud = new addition();

            int result = stud.calculate(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),
Convert.ToChar(comboBox1.Text));

            label4.Text = "result : " + result;




        }
    }
}
