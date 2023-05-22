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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace feerevision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Product.getproducttypename();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(dr["Product_Type_Name"]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = Product.getproductname(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables[0];
            comboBox2.DisplayMember = "product_Name";//fill product name using combobox1

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = Product.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox1.Text = dr["ProductPrice"].ToString();
            }
        }
    }
}
