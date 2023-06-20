using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace fendhal3
{
    public partial class Form1 : Form
    {
        
        enum paymentmode { Cash, EMI }
        paymentmode mode;
        enum Gender { Male, Female }   
        Gender gender;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now; 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Invoicegeneration.getname();
            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "Name";
           // listBox1.ValueMember = "ID";

           // TableLayoutCellPaintEventArgs.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox1.SelectedItem != null)
            //{
            //    string selectedValue = listBox1.SelectedItem.ToString();
            //}
            DataSet ds1 = Invoicegeneration.getproductname(listBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox1.Text = dr["Name"].ToString();
                textBox2.Text = dr["AVAILABLE_QTY"].ToString();
                textBox3.Text = dr["SELL_QTY"].ToString();
                textBox4.Text = dr["PRICE_PER_UNIT"].ToString();
                
               // textBox10.Text=textBox3.Text;
                //textBox9.Text=textBox4.Text;    


            }
            DataSet ds2 = Invoicegeneration.getcgst(listBox1.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                textBox5.Text = dr["cgst"].ToString();

                textBox6.Text = dr["sgst"].ToString();
            }


           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //double amount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text)/100.0;
            //textBox7.Text = amount.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //double amount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox6.Text) / 100.0;
            //textBox8.Text = amount.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
            textBox14.Text = "";
            textBox15.Text="";
            if (radioButton3.Checked)
            {
                textBox14.Clear();
                
                mode = paymentmode.Cash;
                textBox14.Text = textBox9.Text;
            }
            
           

          double netamount= Convert.ToDouble(textBox9.Text) + Convert.ToDouble(textBox8.Text);
            textBox15.Text = netamount.ToString();


           
            }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            textBox14.Text = "";
            textBox15.Text = "";


        }
        

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
           // double netamt = Convert.ToDouble(textBox9.Text) - Convert.ToDouble(textBox14.Text);
           // textBox15.Text = netamt.ToString();

        }

        private void textBox14_Leave(object sender, EventArgs e)
        {

            rfill();
            //mode = paymentmode.EMI;
            //double total = Convert.ToDouble(textBox9.Text);
            //double paid = Convert.ToDouble(textBox14.Text);
            //if (paid > total)
            //{
            //    MessageBox.Show("paid amount not greater than total amount");
            //}
            //else
            //{
            //    double netamt = Convert.ToDouble(textBox9.Text) - Convert.ToDouble(textBox14.Text);
            //    textBox15.Text = netamt.ToString();
            //}




        }
        public void rfill()
        {
            mode = paymentmode.EMI;
            double total = Convert.ToDouble(textBox9.Text);
            double paid = Convert.ToDouble(textBox14.Text);
            if (paid > total)
            {
                MessageBox.Show("paid amount not greater than total amount");
            }
            else
            {
                double netamt = Convert.ToDouble(textBox9.Text) - Convert.ToDouble(textBox14.Text);
                textBox15.Text = netamt.ToString();
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            //1st table
            string gender = null;

            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "female";
            }
                string result=Invoicegeneration.getcustomer(textBox11.Text,textBox12.Text,gender,textBox13.Text,Convert.ToDecimal(textBox14.Text));
            MessageBox.Show(result);

            //2nd table 
            if (radioButton3.Checked)
            {
                mode = paymentmode.Cash;
            }
            else if (radioButton4.Checked)
            {
                mode = paymentmode.EMI;
            }
            result = Invoicegeneration.refselling(Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, Convert.ToInt32(textBox10.Text),textBox16.Text,Convert.ToString(mode),Convert.ToInt32(textBox14.Text),Convert.ToInt32(textBox5.Text),Convert.ToInt32(textBox6.Text),Convert.ToInt32(textBox15.Text));
            MessageBox.Show(result);
        }

        private void radioButton4_Leave(object sender, EventArgs e)
        {
             rfill();

            //double netamt = Convert.ToDouble(textBox9.Text) - Convert.ToDouble(textBox14.Text);
            //textBox15.Text = netamt.ToString();

            int totalprice=Convert.ToInt32(textBox9.Text);
            int piadamount=Convert.ToInt32(textBox14.Text); 
            int remainingamt=totalprice-piadamount;
            double emiamount = Convert.ToInt32(textBox15.Text);
            if(radioButton4.Checked)
            {
                if(remainingamt>0)
                {
                    emiamount = remainingamt/3.0;
                }
                DataSet ds = new DataSet();
                DataTable dt=new DataTable("emi");
                DataRow dr;
                dt.Columns.Add(new DataColumn("productname", typeof(string)));
                dt.Columns.Add(new DataColumn("price", typeof(int)));
                dt.Columns.Add(new DataColumn("Emi", typeof(decimal)));

                for (int i = 1; i <= 3; i++)
                {
                    dr=dt.NewRow();
                    dr[0] = i;
                    //dr[1] = textBox1.Text;
                    //dr[2] =textBox9.Text;
                    dr[1] =textBox9.Text;
                    dr[2] = emiamount;
                    dt.Rows.Add(dr);

                }
                ds.Tables.Add(dt);
                dataGridView1.DataSource = ds.Tables[0];




            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double totalprice = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox10.Text);
            textBox9.Text = totalprice.ToString();


            double amount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text) / 100.0;
            textBox7.Text = amount.ToString();

            double amount2 = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox6.Text) / 100.0;
            textBox8.Text = amount2.ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    

