using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fendhal_revision
{
    public partial class Form1 : Form
    {
        enum Nationality{Indian,NRI }//kyu bna rhe taki indian select kre to addition hona chahiye nhi to jiasa hai waisa he rhe
                                     //cgst+sgst
        Nationality nationality;
        public Form1()
        {

            InitializeComponent();
            dateTimePicker1.Value=DateTime.Now;
            dateTimePicker1.MinDate=DateTime.Now;
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(! char.IsControl(e.KeyChar)&& ! char.IsDigit(e.KeyChar) ) {

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

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.getproducttypename();
           foreach(DataRow dr in ds.Tables[0].Rows)
            {
                comboBox1.Items.Add(dr["Product_Type_Name"]);
            }
            




        }
        int CGST = 0;
        int SGST = 0;
        int IGST = 0;
        int TGST = 0;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = ProductStore.getproductname(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables[0];
            comboBox2.DisplayMember = "product_Name";//fill product name using combobox1


            DataSet ds2 = ProductStore.getgttables(comboBox1.Text);
            //foreach (DataRow dr in ds2.Tables[0].Rows)//fill gst using combobox1
            //{


            //    textBox3.Text = dr["CGST"].ToString();
            //    textBox4.Text = dr["SGST"].ToString();
            //    textBox5.Text = dr["IGST"].ToString();
            //}
            //}
            DataSet ds3 = ProductStore.getgttables(comboBox1.Text);

            foreach (DataRow dr in ds3.Tables[0].Rows)
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
            textBox4.Text = CGST.ToString();

            textBox5.Text = CGST.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text = CGST.ToString();
            textBox4.Text = CGST.ToString();
            textBox5.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text));


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = CGST.ToString();
            textBox4.Text = CGST.ToString();

            textBox5.Text = CGST.ToString();



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds4 = ProductStore.getprice(comboBox2.Text);
            {
                foreach (DataRow dr in ds4.Tables[0].Rows)
                {

                    textBox9.Text = dr["ProductPrice"].ToString();

                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {


                double totalamount = Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox9.Text);
                textBox11.Text = totalamount.ToString();

                double cgst = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox3.Text) / 100.0);
                textBox6.Text = cgst.ToString();

                double sgst = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox4.Text) / 100.0);
                textBox7.Text = sgst.ToString();

                double igst = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
                textBox8.Text = igst.ToString();

                double netamount = Convert.ToDouble(textBox8.Text) + (Convert.ToDouble(textBox11.Text));
                textBox12.Text = netamount.ToString();


            }
        }













        //private void textBox10_TextChanged(object sender, EventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {

        //        e.Handled = true;
        //    }

        //}

    }
    }
