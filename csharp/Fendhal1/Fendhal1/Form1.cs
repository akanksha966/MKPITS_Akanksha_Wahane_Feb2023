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

namespace Fendhal1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate=DateTime.Now;   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet Ds = Product.GetTableProductCategory();
            comboBox1.DataSource = Ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet Ds = Product.GetProductName(comboBox1.Text);
            comboBox2.DataSource= Ds.Tables[0]; 
            comboBox2.DisplayMember = "Product_Name";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet Ds2= Product.GetProductPrice(comboBox2.Text);
            foreach(DataRow dr in Ds2.Tables[0].Rows)
            {
               textBox9.Text= dr["ProductPrice"].ToString();
            }

            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                    e.Handled = true;
            }
        }
    }
}
