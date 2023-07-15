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
using System.Security.Cryptography.X509Certificates;

namespace Fendhal1
{
    public partial class Form1 : Form
    {
      enum Nationality { Indian,NRI}
        Nationality nationality;


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
        int CGST = 0;
        int SGST = 0;
        int IGST = 0;
        int TGST = 0;



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet Ds = Product.GetProductName(comboBox1.Text);
            comboBox2.DataSource= Ds.Tables[0]; 
            comboBox2.DisplayMember = "Product_Name";



            DataSet DS3 = Product.GetInvoiceDetails(comboBox1.Text);
            foreach (DataRow Dr in DS3.Tables[0].Rows)
            {
                CGST = Convert.ToInt32(Dr["CGST"].ToString());
                SGST = Convert.ToInt32(Dr["SGST"].ToString());
                IGST = Convert.ToInt32(Dr["IGST"].ToString());

            }



            if (nationality == 0)
            {
                TGST = CGST + SGST;
            }
            else if (radioButton2.Checked)
            {
                TGST = IGST;


            }

            textBox3.Text = CGST.ToString();
            textBox4.Text = SGST.ToString();
            textBox5.Text = TGST.ToString();


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
            if(textBox10.Text=="")
            {
                
            }
            else
            {
                Calculate_Total();
            }
           

        }
        public void Calculate_Total()
        {
            Double TotalAmount = Convert.ToInt32(textBox9.Text) * Convert.ToInt32(textBox10.Text);
            textBox11.Text = TotalAmount.ToString();
            //price*cgst/100.0
            double CGSTAmount =( Convert.ToInt32(textBox9.Text)) * (Convert.ToInt32(textBox3.Text)) / 100.0f;
            textBox6.Text = CGSTAmount.ToString();

            double SGSTAmount = (Convert.ToInt32(textBox9.Text)) * (Convert.ToInt32(textBox4.Text)) / 100.0f;
            textBox7.Text = SGSTAmount.ToString();

            double IGSTAmount = (Convert.ToInt32(textBox9.Text)) * (Convert.ToInt32(textBox5.Text)) / 100.0f;
            textBox8.Text = IGSTAmount.ToString();

            double NETAmount = (Convert.ToInt32(textBox11.Text)) + (Convert.ToInt32(textBox8.Text));
            textBox12.Text = NETAmount.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }
        public void Save()
        {
            if(textBox1.Text=="" || textBox2.Text=="" )
            {
                MessageBox.Show("Pls Fill All the Details","Fill",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else if(textBox10.Text=="0")
            {
                MessageBox.Show("Quantity Can Not Be Zero","Pls Fill Quantity",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
