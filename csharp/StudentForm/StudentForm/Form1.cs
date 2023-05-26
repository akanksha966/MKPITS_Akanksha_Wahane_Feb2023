using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        //int totalprice = 0;
        //int paidamounnt = 0;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds=Student.getcoursename();
            comboBox4.DataSource = ds.Tables[0];
            comboBox4.DisplayMember = "CourseName";

            DataSet ds2 = Student.getcountryname();
            comboBox1.DataSource = ds2.Tables[0];
            comboBox1.DisplayMember = "CountryName";
            //foreach(DataRow dr in ds2.Tables["country2"].Rows)
            //{
            //    comboBox1.Text = dr["CountryName"].ToString();
            //}


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds3 = Student.getstatename(comboBox1.Text);
            comboBox2.DataSource = ds3.Tables[0];
            comboBox2.DisplayMember = "StateName";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds4=Student.getcityname(comboBox2.Text);
            comboBox3.DataSource = ds4.Tables[0];
            comboBox3.DisplayMember = "CityName";


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(! char.IsDigit(e.KeyChar) && !  char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds4=Student.getfees(comboBox4.Text);
            foreach(DataRow dr in ds4.Tables[0].Rows) {

                textBox3.Text = dr["Fees"].ToString();
            }
           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { 
       
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "0")
            {
                MessageBox.Show("fees cannot be zero");
            }
            else
            {


                minusdata();
                

            }
            

        }

        public void minusdata()
        {
            double Totalbalance = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox4.Text);
            textBox5.Text = Totalbalance.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
            clearall();
        }
        public void save()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("pls please the details");
            }
            else
            {
                string result = Student.save(textBox1.Text, comboBox4.Text, dateTimePicker1.Value, comboBox1.Text, comboBox2.Text, comboBox3.Text, Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text));
                MessageBox.Show(result);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

        }
    }
}
