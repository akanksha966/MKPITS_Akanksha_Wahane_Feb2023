using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;

using System.Data.SqlClient;

namespace staticconnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //************code is dissconnected environment * ******

            DataSet ds = EmployeeDetails.GetCity();
            foreach (DataRow dr in ds.Tables["City"].Rows) 
            {
             comboBox1.Items.Add(dr["cityname"].ToString());
            }


            //*******code is connected environment**********

            //    SqlDataReader dr = EmployeeDetails.Getcity();
            //    while (dr.Read())
            //    {
            //        comboBox1.Items.Add(dr["Cityname"].ToString());

            //    }

            /////////code is grid add////////////////
            DataSet dsa = EmployeeDetails.getEmployeeDetails();
            dataGridView1.DataSource = dsa.Tables[0];
            ////////////////////////////////////////////

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string gender = null;
            
            if(radioButton1.Checked)
            {
                gender = "Male";
            }
            else if(radioButton2.Checked)
            {
                gender = "female";
            }
            label8.Text = EmployeeDetails.InsertRecord(textBox1.Text, textBox2.Text, gender,textBox3.Text,textBox4.Text,comboBox1.Text,dateTimePicker1.Text);
            clearall();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            label8.Text = EmployeeDetails.UpdateUsers(textBox1.Text,textBox2.Text);

            clearall();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            
            label8.Text = EmployeeDetails.DeleteUsers(textBox4.Text);
            clearall();        
        }

        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = " ";
            dateTimePicker1.Value= DateTime.Now;

            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = EmployeeDetails.searchemployee(textBox1.Text);
            dataGridView1.DataSource = ds.Tables[0];
            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            
            string gender = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            textBox3.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            textBox4.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            comboBox1.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            dateTimePicker1.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            if (gender == "male")
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
                 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearall();
        }
    }

    //private void button1_Click(object sender, EventArgs e)
    //{
    //    DataSet ds=EmployeeDetails.sea
    //}
}

