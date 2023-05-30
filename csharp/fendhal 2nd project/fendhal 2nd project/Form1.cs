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

namespace fendhal_2nd_project
{
    public partial class Form1 : Form
        
    {
        enum select_Category { Student,ITProfessional}
        select_Category category;
        
        enum Gender { Male,Female,Other}
        Gender gender;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;   
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataSet ds = CourseRegistration.getnationname();//return dataset esilye dataset (ds)
            //comboBox1.DataSource = ds.Tables[0];
            //comboBox1.DisplayMember = "NationName";
            ////comboBox1.ValueMember = "NationID";


            
            
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // DataSet ds1=CourseRegistration.getstatename(comboBox1.Text);
           // comboBox2.DataSource = ds1.Tables["TableState"];
           // comboBox2.DisplayMember = "StateName";
           //// comboBox2.ValueMember = "StateID";


            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataSet ds2=CourseRegistration.getcityname(comboBox2.Text);
            //comboBox3.DataSource = ds2.Tables[0];
            //comboBox3.DisplayMember = "CityName";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox3.Clear();
                textBox4.Clear();
                category = select_Category.Student;
                textBox2.Text = "1000";
            }
            
            
            
        }

      

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //category = select_Category.ITProfessional;
            //double ITp = 3000;
            //textBox2.Text = ITp.ToString(); 
           

            if(radioButton2.Checked)
            {
                textBox3.Clear();
                textBox4.Clear();
                category = select_Category.ITProfessional;
                textBox2.Text = "3000";
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //double balance=Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text); 
            //textBox4.Text=balance.ToString();   
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(! char.IsControl(e.KeyChar) && ! char.IsDigit(e.KeyChar ))
                {

                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            DataSet ds = CourseRegistration.getnationname();//return dataset esilye dataset (ds)
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationID";

            textBox2.Text = "1000";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            check_balance_amount();
        }
        double total = 0;
        double fiftypercent = 0;
        double bal_amount = 0;
        public void check_balance_amount()
        {
             total = Convert.ToDouble(textBox2.Text);
            double paid =Convert.ToDouble(textBox3.Text);
             fiftypercent = 0;
            if (category == 0)//student
            {
                fiftypercent = total * 0.5;
            }
            else
            {
                fiftypercent = total * 0.8;
            }
            if (Convert.ToDouble(textBox3.Text) < fiftypercent)
            {
                MessageBox.Show("paid amount should be atleast 50% for Student And 80% for ITProffessional ");

            }
            else if (paid>total)
            {
                MessageBox.Show("paid amount should not be greater than total amount ");
                textBox3.Clear();
            }

            else
            {
                
                bal_amount = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                textBox4.Text = bal_amount.ToString();

            }


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataSet ds1 = CourseRegistration.getstatename(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables["TableState"];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataSet ds2 = CourseRegistration.getcityname(comboBox2.Text);
            comboBox3.DataSource = ds2.Tables[0];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityID";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                gender=Gender.Male;//0
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked)
            {
                gender = Gender.Female;//1
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked)
            {
                gender = Gender.Other;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savebutton();
        }

        public void savebutton()
        {
            if(textBox1.Text==""||textBox2.Text==""||textBox3.Text=="")
            {
                MessageBox.Show("pls fill the details");
            }
                else
            {

                string result = CourseRegistration.savetablecourseregdetail(Convert.ToInt32(category), textBox1.Text, Convert.ToInt32(gender));
                MessageBox.Show(result);

                //////////5th table insert//////
                result = CourseRegistration.savetablereg(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
                MessageBox.Show(result);
                ///6 th table insert///


                result = CourseRegistration.savetablefeedetails(Convert.ToDouble(textBox2.Text), fiftypercent, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), dateTimePicker1.Value);
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
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";

        }
    }
}
