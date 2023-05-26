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
using System.Data;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;

namespace fe11
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian,NRI}
        Nationality nationality;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Products.getproducttypename();
            {
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "Product_Type_Name";
                comboBox1.ValueMember = "Product_Category_ID";
            }

           
        }
        int CGST = 0;
        int SGST = 0;
        int IGST = 0;
        int TGST = 0;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = Products.getproductname(comboBox1.Text);
            {
                comboBox2.DataSource = ds2.Tables["TableProduct"];
                comboBox2.DisplayMember = "Product_Name";
                comboBox2.ValueMember = "ProductID";
            }
            DataSet ds3 = Products.cgstdetail(comboBox1.Text);
            foreach(DataRow dr in ds3.Tables[0].Rows)
            {
                CGST = Convert.ToInt32(dr["CGST"].ToString());
                SGST = Convert.ToInt32(dr["SGST"].ToString());
                IGST = Convert.ToInt32(dr["IGST"].ToString());



            }
            if(nationality==0)
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
            DataSet ds3 = Products.productprice(comboBox2.Text);
            foreach (DataRow dr in ds3.Tables[0].Rows)
            {
                textBox9.Text = dr["ProductPrice"].ToString();
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality= Nationality.Indian;
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text=Convert.ToString(Convert.ToInt32(textBox3.Text) +Convert.ToInt32(textBox4.Text));
            priceamount();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = IGST.ToString();
            priceamount();





        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {

                priceamount();
            }
        }

            public void priceamount()
            {
                double tamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);

                textBox11.Text = tamount.ToString();


            double camount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox3.Text)/100.0;

            textBox6.Text = camount.ToString();

            double samount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox4.Text) / 100.0;

            textBox7.Text = camount.ToString();

            double iamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text) / 100.0;

            textBox8.Text = iamount.ToString();

            double namount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);

            textBox12.Text = namount.ToString();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFill();
        }
        public void saveFill()
        {
            if(textBox1.Text ==""|| textBox2.Text =="")
            {
                MessageBox.Show("pls fill others detail");
            }
            else if (textBox10.Text=="0")
            {
                MessageBox.Show("Quantity cannot be zero");

            }
            else
            {
                string result = Products.savetableinvoicedetails(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue),
                    Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality), dateTimePicker1.Value,
                    Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox3.Text),
                    Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text),
                    Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox11.Text));
                MessageBox.Show(result);



            }
        }
    }
    }

