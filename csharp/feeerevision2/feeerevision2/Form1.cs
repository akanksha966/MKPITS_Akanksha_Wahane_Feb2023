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

namespace feeerevision2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Productinfo.tableproductcategory();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                // comboBox1.Items.Add(dr["Product_Type_Name"]);
                //comboBox1.Text = dr["Product_Type_Name"]

                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "Product_Type_Name";//fill product name using combobox1

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = Productinfo.getproductname(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                comboBox2.DataSource = ds1.Tables[0];
                comboBox2.DisplayMember = "Product_Name";



            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = Productinfo.getprice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox9.Text = dr["ProductPrice"].ToString();


            }

        }
    }
}
