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
using System.Security.Cryptography;

namespace revision_again
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductDetail.getproducttypename();
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //    comboBox1.Items.Add(dr["Product_Type_Name"]);
            //}



            comboBox1.DataSource = ds.Tables["TableProductCategory"];
            comboBox1.DisplayMember = "Product_Type_Name";



        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = ProductDetail.getproductname(comboBox1.Text);
            comboBox2.DataSource = ds2.Tables[0];
            comboBox2.DisplayMember = "Product_Name";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataSet ds4 = ProductDetail.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds4.Tables[0].Rows)
            {
                textBox9.Text = dr["ProductPrice"].ToString();
            }


        }
    }
}

