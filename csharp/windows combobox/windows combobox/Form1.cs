using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ADD COUNTERY TO THE FIRST CHECKBOX TO SECOUND CHECKBOX.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string country = comboBox1.Text;
            switch(country)
            {
                case "INDIA":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Bhandara");
                    comboBox2.Items.Add("Tumsar");
                    break;



                case "USA":
                    comboBox2.Items.Add("Londan");
                    comboBox2.Items.Add("singapur");
                    comboBox2.Items.Add("Newyork");

                    break;

            }
        }
        //LIST BOX CODE ALREADY DEFINED FUNCTION
        

        //double click on button and write code
        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "country :" + comboBox1.Text + "\n";
            label4.Text += "City:" + comboBox2.Text + "\n";
            label4.Text += "Course:" + listBox1.SelectedItem.ToString();
            label4.Text += "Dob : " + dateTimePicker1.Text + "\n";
            label4.Text += "PShone no : " + maskedTextBox1.Text + "\n";




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }
    }
}
