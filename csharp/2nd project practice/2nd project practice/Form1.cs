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

namespace _2nd_project_practice
{
    public partial class Form1 : Form
    {
        enum category { Student,ITProffessional}
        category Category;
       enum Gender { Male, Female,Other }
        Gender gender;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate=DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Courese.getnation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationId";
            textBox2.Text = "1000";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        DataSet ds3= Courese.getcityname(comboBox2.Text);
           comboBox3.DataSource = ds3.Tables[0];
            comboBox3.DisplayMember = "Cityname";
            comboBox3.ValueMember = "CityID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = Courese.getstatename(comboBox1.Text);
            comboBox2.DataSource = ds2.Tables[0];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            save2();
        }

        double totalamount = 0;
        double fp = 0;
        double balamount = 0;
        public void save2()
        {
             totalamount = Convert.ToDouble(textBox2.Text);
            double paidamount = Convert.ToDouble(textBox3.Text);
            fp = 0;
            if (Category == 0)
            {
                fp = totalamount * 0.5;
            }
            else
            {
                fp = totalamount * 0.8;
            }
            if (Convert.ToDouble(textBox3.Text) < fp)
            {

                MessageBox.Show("amount should be 50 or 80 percent");
            }
            else if (paidamount > totalamount)
            {
                MessageBox.Show("paid amount should not be greater than total amount ");

            }
            else
            {
                 balamount = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                textBox4.Text = balamount.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Clear();
                textBox2.Clear();
                Category = category.Student;
                textBox2.Text = "1000";
            }



            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                textBox3.Clear();
                textBox2.Clear();
                Category = category.ITProffessional;
                textBox2.Text = "3000";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        if(!radioButton3.Checked)
            {
                gender=Gender.Male; 
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(!radioButton4.Checked) { 

                gender=Gender.Female;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(!radioButton5.Checked) { 
                gender=Gender.Other;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }
        public void save()
        {
            string result=Courese.coursereg(Convert.ToInt32(Category),textBox1.Text,Convert.ToInt32(gender));
            MessageBox.Show(result);
            result = Courese.regaddress(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
            MessageBox.Show(result);        
        }
    }
}
