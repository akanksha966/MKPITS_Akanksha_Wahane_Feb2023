using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorial_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            int fact=1;
           
           
            
            num=Convert.ToInt32(textBox1.Text);
            for(int i=num;i>0;i--)
            {
                fact = fact * i;
                
               

            }
            label2.Text = ("factorial is " + fact);
        }

    }
}
