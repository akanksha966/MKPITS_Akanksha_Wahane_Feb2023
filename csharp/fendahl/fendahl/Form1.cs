using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using System.Data.SqlClient;
namespace fendahl
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian,NRI}//enum class
        Nationality nationality;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //code contact yey code esiliye previous na ja ske aur jis din code open kiye usi din ke date show krenga
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            //quantity
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.Gettableproductcategory();

            comboBox1.DataSource = ds.Tables["TableProductCategory"];
            comboBox1.DisplayMember = "Product_Type_Name";



        }int CGST = 0;
        int SGST = 0;
        int IGST = 0;
        int TGST = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //productcategory to product name code
            DataSet ds = ProductStore.Gettableproductname(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";

            DataSet ds1=ProductStore.GetGstDetails(comboBox1.Text); 
            //foreach(DataRow dr in ds1.Tables[0].Rows)
            //{
            //    textBox3.Text = dr["CGST"].ToString();
            //    textBox4.Text = dr["SGST"].ToString();
            //    textBox5.Text = dr["IGST"].ToString();
            //}
            foreach(DataRow dr in ds1.Tables[0].Rows)
            {
                CGST = Convert.ToInt32(dr["CGST"].ToString());
                SGST = Convert.ToInt32(dr["SGST"].ToString()) ;
                IGST = Convert.ToInt32(dr["IGST"].ToString() );
            }
            if(nationality==0)
            {
                TGST = CGST + SGST;
            }
            else
            {
                TGST = IGST;
            }
            textBox3.Text=CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = IGST.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1= ProductStore.GetProductPrice(comboBox2.Text);
            foreach(DataRow dr in ds1.Tables[0].Rows)
            {
                textBox9.Text = dr["ProductPrice"].ToString();
            }
        }
       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = Convert.ToString(Convert.ToInt32(textBox3.Text)+Convert.ToInt32(textBox4.Text));



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text=IGST.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {
                //price * qquantity

                double totalamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
                textBox11.Text = totalamount.ToString();

                //price*cgst/100
                double CGSTamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox3.Text) / 100.0);
                textBox6.Text = CGSTamount.ToString();

                double SGSamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox4.Text) / 100.0);
                textBox7.Text = SGSamount.ToString();

                double IGSTamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
                textBox8.Text = IGSTamount.ToString();
                //total price+amount
                double Netamount = Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox11.Text);
                textBox12.Text = Netamount.ToString();
            }







        }
    }
}
