using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deposit_withdraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 10000;
            int amount=Convert.ToInt32(textBox2.Text);
            if(amount > 0 )
            {
                bal = bal + amount;
                label3.Text = ("deposit amount is " + bal);
            }
            else
            {
                label3.Text = ("enter amount greater than 0");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bal = 20000;
            int final;
            int amount = Convert.ToInt32(textBox2.Text);
            if(amount<=bal)
            {
                final = bal - amount;
                label3.Text = ("after withdraw balance " + final);
                
            }
            else
            {
                label3.Text = ("insufficient balance");


            }

        }
    }
}
