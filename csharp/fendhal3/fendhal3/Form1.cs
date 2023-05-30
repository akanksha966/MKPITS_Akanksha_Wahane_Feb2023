using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fendhal3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now; 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Invoicegeneration.getname();
            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox1.SelectedItem != null)
            //{
            //    string selectedValue = listBox1.SelectedItem.ToString();
            //}
            DataSet ds1 = Invoicegeneration.getproductname(listBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox1.Text = dr["Name"].ToString();
                textBox2.Text = dr["AVAILABLE_QTY"].ToString();
                textBox3.Text = dr["SELL_QTY"].ToString();
                textBox4.Text = dr["PRICE_PER_UNIT"].ToString();
                
                textBox10.Text=textBox3.Text;
                textBox9.Text=textBox4.Text;    


            }
            DataSet ds2 = Invoicegeneration.getcgst(listBox1.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                textBox5.Text = dr["cgst"].ToString();

                textBox6.Text = dr["sgst"].ToString();
            }


           // double amount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text));
            //textBox7.Text = amount.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //double amount=Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text);
            //textBox7.Text = amount.ToString();      
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text)/100.0;
            textBox7.Text = amount.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox6.Text) / 100.0;
            textBox8.Text = amount.ToString();
        }
    }
    
}
