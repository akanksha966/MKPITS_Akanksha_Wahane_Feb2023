using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] arr = { 1, 2, 3, 4, 5 };


            for (int i = 0; i < arr.Length; i++)
            {
                



                    if (arr[i]>6)
                    {

                    textBox1.Text = ("" + arr[0]);


                  button1.Text = ("" + arr[1]);
                    textBox1.Text = ("" + arr[2]);


                }




        



                label2.Text = ("Result "+button2.Text);


                }
            }
        }
    }


    



