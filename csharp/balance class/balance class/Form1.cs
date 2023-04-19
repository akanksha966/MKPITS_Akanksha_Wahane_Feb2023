using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balance_class
{
    public partial class Form1 : Form
    {
        int total;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bank stud= new bank();
            int total = Convert.ToInt32(stud.deposit(Convert.ToInt32(textBox1.Text)), Convert.ToInt32(stud.withdraw(Convert.ToInt32(textBox2.Text)), Convert.ToInt32(stud.showbalance(Convert.ToInt32(textBox3.Text)));


        
            label4.Text = ("total balance is " + total);
        }
    }
}
