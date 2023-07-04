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
namespace fendhalna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Product.getname();
            comboBox1.DataSource = ds.Tables["TableProductCategory"];
            comboBox1.DisplayMember= "Product_Type_Name";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Product.gerre(comboBox1.Text);
            comboBox2.DataSource = ds.Tables["TableProduct"];
            comboBox2.DisplayMember = "product_name";

        }
    }
}
