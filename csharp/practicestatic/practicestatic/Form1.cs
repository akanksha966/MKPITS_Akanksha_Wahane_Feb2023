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
using System.Data;
    
namespace practicestatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           label3.Text=userclass.InsertRecord(textBox1.Text,textBox2.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label3.Text = userclass.UpdateRecord(textBox1.Text, textBox2.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label3.Text = userclass.UpdateRecord(textBox1.Text, textBox2.Text);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = userclass.deleterecord(textBox1.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = userclass.getcity();
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(dr["cityname"]);

            }


            DataSet ds1 = userclass.getstate();


            foreach (DataRow dr in ds1.Tables["state"].Rows)
            {
                comboBox2.Items.Add(dr["statename"]);
            }

            DataSet ds2=userclass.getgridview();
            dataGridView1.DataSource = ds2.Tables["user1"];
           


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds3= userclass.getsearch(textBox1.Text);
            dataGridView1.DataSource = ds3.Tables["user1"];
           // textBox2.Text = ds3.Tables[0].Rows[2].ToString();
           // textBox2.Text = ds3.Tables[0].Rows[0].ItemArray[1].ToString();


        }
    }
}
