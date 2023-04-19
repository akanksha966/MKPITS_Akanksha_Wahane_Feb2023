using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace display_2Darray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] arr;
        int row = 0;
        int col = 0;
        int i = 0;
        int j = 0;

        private void button1_Click(object sender, EventArgs e)
        {
           
            row=Convert.ToInt32(textBox1.Text);
            col = Convert.ToInt32(textBox2.Text);
            arr=new int[row,col];
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(i<row)
            {
                if (j < col)
                {
                    arr[i, j] = Convert.ToInt32(textBox3.Text);

                    textBox3.Clear();
                    textBox3.Focus();

                    j++;
                }
                if (j == col)
                {
                    i = i + 1;
                    j = 0;
                }

                if (i == row)
                {
                    button2.Enabled = false;
                    button3.Enabled = true;

                }


            }
            






        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(i=0;i<row;i++) { 
                for(j=0;j<col;j++)
                {
                    label4.Text="result is " + arr[i,j]+ " ";

                }
            }
        }
    }
}
