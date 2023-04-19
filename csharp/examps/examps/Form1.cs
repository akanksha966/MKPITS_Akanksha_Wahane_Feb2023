using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (radioButton2.Checked)
            {
                total = total + 10;

            }
            if (radioButton3.Checked)
            {
                total = total + 10;


            }
            if (radioButton6.Checked)
            {
                total = total + 10;


            }
            if (radioButton7.Checked)
            {
                total = total + 10;


            }
            if (radioButton9.Checked)
            {
                total = total + 10;

            }
            label7.Text = "total out of 50 :" + total;
        }

            int cnt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
                cnt = cnt + 1;
                if (cnt <= 15)
                {
                    label8.Text = "Time left : 00 : " + cnt + " sec";
                }
                else

                {

                    button1.Enabled = false;
                    timer1.Enabled = false;
                    label8.Enabled = false; 
                    MessageBox.Show("time over");

                }
            }
        }
    }

