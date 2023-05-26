using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examfendhal
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian, NRI }
        Nationality nationality;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Product.getproductname();
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{


            //    comboBox1.Items.Add(dr["Product_Type_Name"]);
            //}
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_ID";

        }
        int CGST = 0;
        int SGST = 0;
        int IGST = 0;
        int TGST = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = Product.getname(comboBox1.Text);
            comboBox2.DataSource = ds2.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "ProductID";

            ///////////////cgst ,sgst,igst code 
            DataSet ds3 = Product.getgstdetails(comboBox1.Text);
            foreach (DataRow dr in ds3.Tables[0].Rows)
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds3 = Product.getprice(comboBox2.Text);
            foreach (DataRow dr in ds3.Tables[0].Rows)
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
            calculate_total();




        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = IGST.ToString();
            calculate_total();



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
            ////total amount
            double totalamount = Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox9.Text);
            textBox11.Text = totalamount.ToString();
            //price*cgst/100.0
            double CGSTamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox3.Text) / 100.0);
            textBox6.Text = CGSTamount.ToString();

            double SGSTamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox4.Text) / 100.0);
            textBox7.Text = SGSTamount.ToString();

            double IGSTamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
            textBox8.Text = IGSTamount.ToString();

            double netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
           textBox12.Text = netamount.ToString();

            





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(! char.IsControl(e.KeyChar) && ! char.IsDigit(e.KeyChar ))
             { 
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                e.Handled = true;
            }

        }

        public void checkuserdetails()
        {
            if(textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("please fill the details");
            }
            else if (textBox10.Text=="0")
            {
                MessageBox.Show("Quantity cannot be zero");
            }
            else
            {
                string result = Product.saveinvoicedetails(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), 
                    Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality), 
                    dateTimePicker1.Value, Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text), 
                    Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), 
                    Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox11.Text));
                MessageBox.Show(result);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkuserdetails();

        }

        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Value= DateTime.Now;
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();  
            textBox12.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();

        }
    }
        
    }

