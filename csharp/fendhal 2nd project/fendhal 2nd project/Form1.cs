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
        int Student = 100;
        int ITProfessional = 3000;
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
            DataSet ds = CourseRegistration.getnationname();//return dataset esilye dataset (ds)
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "NationName";
            //comboBox1.ValueMember = "NationID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1=CourseRegistration.getstatename(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables["TableState"];
            comboBox2.DisplayMember = "StateName";
            //  comboBox2.ValueMember = "StateID";


            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2=CourseRegistration.getcityname(comboBox2.Text);
            comboBox3.DataSource = ds2.Tables[0];
            comboBox3.DisplayMember = "CityName";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            category = select_Category.Student;
            double Student = 1000;
            
            textBox2.Text=Student.ToString();
            

            
            
            
        }

      

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            category = select_Category.ITProfessional;
            double ITp = 3000;
            textBox2.Text = ITp.ToString(); 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double balance=Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
            textBox4.Text=balance.ToString();   
        }
    }
}
