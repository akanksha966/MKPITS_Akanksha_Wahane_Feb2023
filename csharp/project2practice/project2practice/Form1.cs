using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace project2practice
{
    public partial class Form1 : Form
    {
        enum Category { Student, ITProffessional }
        Category category;
        enum Gender { Male,Female,Other}
        Gender gender;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = courseregestration.getnationname();
           comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "NationName";   
            comboBox1.ValueMember = "NationID";
            textBox2.Text = "1000";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = courseregestration.getcityname(comboBox2.Text);
            comboBox3.DataSource = ds2.Tables[0];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityID";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = courseregestration.getstatename(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables["TableState"];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            category = Category.Student;
            textBox2.Text = "1000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            category = Category.ITProffessional;
            textBox2.Text = "3000";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            levecode();
        }
        double totalamount = 0;
        double fp = 0;
        double balamount = 0;

        public void levecode()
        {
             totalamount = Convert.ToDouble(textBox2.Text);
            double Paid = Convert.ToDouble(textBox3.Text);
             fp = 0;
            if (category == 0)
            {
                fp = totalamount * 0.5;
            }
            else
            {
                fp = totalamount * 0.8;
            }
            if (Convert.ToDouble(textBox3.Text) < fp)
            {
                MessageBox.Show("amount should 50 or 80 percent");
            }
            else if (Paid > totalamount)
            {
                MessageBox.Show("paid amount should not be greater than total amount ");

            }
            else
            {
                 balamount = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                textBox4.Text = balamount.ToString();
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(! char.IsDigit(e.KeyChar) && ! char.IsControl(e.KeyChar ))
            {
                e.Handled = true;   
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }
        public void Save()
        {
            string result = courseregestration.TableCourseReg(Convert.ToInt32(category), textBox1.Text, Convert.ToInt32(gender));
            MessageBox.Show(result);

            result = courseregestration.regaddress(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
            MessageBox.Show(result);


            result = courseregestration.tablefeedateil2(Convert.ToDouble(textBox2.Text), fp, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), dateTimePicker1.Value);
            MessageBox.Show(result);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                gender=Gender.Male;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                gender = Gender.Female;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked)
                {
                gender = Gender.Other;

            }
        }
    }
}
