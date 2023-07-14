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

namespace FendhalM1
{
    public partial class ProductStoreForm1 : Form
    {
        public ProductStoreForm1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;   
            dateTimePicker1.MinDate = DateTime.Now;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet Ds = ProductStore.GetTableProductCategory();
            comboBox1.DataSource = Ds.Tables["TableProductCategory"];
            comboBox1.DisplayMember = "Product_Type_Name";

        }

        private void ProductStoreForm1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) { 

                e.Handled = true;
            }
            
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            { e.Handled = true;}
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
