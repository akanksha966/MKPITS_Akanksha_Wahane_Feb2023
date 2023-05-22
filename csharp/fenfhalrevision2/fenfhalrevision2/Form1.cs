using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;



namespace fenfhalrevision2
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian,NRI}//create class
        Nationality nationality;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.getproducttypename();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(dr["Product_Type_Name"]);
            }
        }
        int CGST = 0;
        int SGST = 0;
        int IGST = 0;
        int TGST = 0;

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
            DataSet ds = ProductStore.getproductname(comboBox1.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                comboBox2.Text = dr["Product_Name"].ToString();

            }
            DataSet ds3=ProductStore.getgttables(comboBox1.Text);

            foreach (DataRow dr in ds3.Tables[0].Rows)
            {
                CGST = Convert.ToInt32(dr["CGST"].ToString());
                SGST = Convert.ToInt32(dr["SGST"].ToString()) ;
                IGST = Convert.ToInt32(dr["IGST"].ToString());



            }

           textBox3.Text= CGST.ToString();
            textBox4.Text = CGST.ToString();

            textBox5.Text = CGST.ToString();

            if (nationality == 0)
            {
                TGST = CGST + SGST;
            }
            else
            {
                TGST = IGST;
            }






        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality=Nationality.Indian;
            textBox3.Text=CGST.ToString();
            textBox4.Text=SGST.ToString();
            textBox5.Text=Convert.ToString(Convert.ToInt32(textBox3.Text)+Convert.ToInt32(textBox4.Text));

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = CGST.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = ProductStore.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox9.Text = dr["ProductPrice"].ToString();
            }


        }

        //private void textBox13_TextChanged(object sender, EventArgs e)
        //{
        //    DataSet ds3 = ProductStore.gettableprice();
        //    foreach(DataRow dr in ds3.Tables["TableProduct"].Rows)
        //    {
        //        textBox13.Text = dr["ProductPrice"].ToString();    
        //    }


        //}
    }
}
    
