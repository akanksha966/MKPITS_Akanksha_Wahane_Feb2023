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

namespace course_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = null;
            result=DatabaseConnection.InsertRecord(textBox1.Text,textBox2.Text,textBox3.Text,comboBox1.Text,textBox4.Text);
            label4.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           
            textBox4.Clear();

        }
    }
}
