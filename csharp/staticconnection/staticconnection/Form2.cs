using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace staticconnection
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = null;
            if(radioButton1.Checked )
            {
                gender = "male";
            }
            else if(radioButton2.Checked ) 
            {
                gender = "female";
            }
           label8.Text=studentclass.getinserted(textBox1.Text,textBox2.Text,gender,textBox3.Text,textBox4.Text,comboBox1.Text,dateTimePicker1.Text);


        }
        public void clearall()
        {
            textBox1.Clear();   
            textBox2.Clear();
            comboBox1.Text = " ";
            dateTimePicker1.Value= DateTime.Now;    
        }
    }
}
