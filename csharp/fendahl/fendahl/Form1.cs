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
using System.Security.Cryptography.X509Certificates;

namespace fendahl
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian, NRI }//enum class
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            comboBox1.ValueMember = "Product_Category_ID";


        }
        int CGST = 0;
        int SGST = 0;
        int IGST = 0;
        int TGST = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //productcategory to product name code
            DataSet ds = ProductStore.Gettableproductname(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "ProductID";

            DataSet ds1 = ProductStore.GetGstDetails(comboBox1.Text);
            //foreach(DataRow dr in ds1.Tables[0].Rows)
            //{
            //    textBox3.Text = dr["CGST"].ToString();
            //    textBox4.Text = dr["SGST"].ToString();
            //    textBox5.Text = dr["IGST"].ToString();
            //}
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                CGST = Convert.ToInt32(dr["CGST"].ToString());
                SGST = Convert.ToInt32(dr["SGST"].ToString());
                IGST = Convert.ToInt32(dr["IGST"].ToString());
            }
            if (nationality == 0)
            {
                TGST = CGST + SGST;
            }
            else
            {
                TGST = IGST;
            }
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = IGST.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = ProductStore.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox9.Text = dr["ProductPrice"].ToString();
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text));



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = IGST.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {
                calculate_total();
            }
        }
        public void calculate_total()
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

            double netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
            textBox12.Text = netamount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkuserdetails();
        }
        public void checkuserdetails()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please fill all the details");
            }
            else if (textBox10.Text == "0")
            {
                MessageBox.Show("Quantity cannot be zero");
            }
            else
            {
                string result = ProductStore.savetableinvoicedetails(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue),
                    Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality), dateTimePicker1.Value,
                    Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox3.Text),
                    Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text),
                    Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox11.Text));
                    MessageBox.Show(result);



                //textbox1=====full name
                // textBox2======contact number
                //comboBox1.SelectedValue=====productcategoryid(Product type name)
                //comboBox2.SelectedValue=====productid(Product name)
                //nationality ( RADIO BUTTON)
                //  dateTimePicker1.Value(INVOICE DATE)
                //textbox10=======QUANTITY
                //textbox9========price
                //textbox3=========CGST
                //textbox4========SGST
                //textbox5===========IGST
                //textbox6========CGST_VAluE
                //textbox7========sGST_VAluE
                //textbox8========iGST_VAluE
                //textbox11========totalamount
            }
        }
        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox10.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox11.Clear();
            textBox12.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall(); 
        }
    }
}

   






        
    
