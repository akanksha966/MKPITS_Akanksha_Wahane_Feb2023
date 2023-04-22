using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movietecket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = string.Empty;
            switch (comboBox1.Text)
            {
                case "PATHAN":
                    comboBox2.Items.Add("smruthi");
                    comboBox2.Items.Add("janki");
                    break;
                case "SULTAN":
                    comboBox2.Items.Add("liberty");
                    comboBox2.Items.Add("cinemax");
                    break;

                case "MILE":
                    comboBox2.Items.Add("alankar");
                    comboBox2.Items.Add("sudama");
                    break;








            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = string.Empty;
            textBox1.Text = "0";

            switch (comboBox2.Text)
            {
                case "smruthi":
                    comboBox3.Items.Add("12:00:PM");
                    comboBox3.Items.Add("3:00:PM");
                    textBox1.Text = "120";
                    break;
                case "janki":
                    comboBox3.Items.Add("10:30:AM");
                    comboBox3.Items.Add("2:00:PM");
                    textBox1.Text = "240";
                    break;

                case "liberty":
                    comboBox3.Items.Add("12:30:PM");
                    comboBox3.Items.Add("4:00:PM");
                    textBox1.Text = "111";
                    break;

                case "cinemax":
                    comboBox3.Items.Add("8:00:AM");
                    comboBox3.Items.Add("12:30:AM");
                    textBox1.Text = "260";
                    break;

                case "alankar":
                    comboBox3.Items.Add("8:00:PM");
                    comboBox3.Items.Add("9:30:AM");
                    textBox1.Text = "110";
                    break;
                case "sudama":
                    comboBox3.Items.Add("10:00:AM");
                    comboBox3.Items.Add("3:45:PM");
                    textBox1.Text = "210";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Movie_Ticket price = null;
            if(radioButton1.Checked)

            {
                price=new Online_Booking(comboBox1.Text, comboBox2.Text, comboBox3.Text,
Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));



            }
            else if(radioButton2.Checked)
            {
                price=new BoxOffice(comboBox1.Text, comboBox2.Text, comboBox3.Text,
Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));

            }
            label7.Text = "total bill is " + price.Calculate_Ticket_Price();


        }
    }
}
