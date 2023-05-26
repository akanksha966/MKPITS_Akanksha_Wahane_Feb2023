using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace project2practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = courseregestration.getnationname();
           comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "NationName";   
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = courseregestration.getcityname(comboBox2.Text);
            comboBox3.DataSource = ds2.Tables["TableCity"];
            comboBox3.DisplayMember = " CityName";
            //comboBox3.ValueMember = "CityID";
            //foreach (DataRow dr in ds2.Tables[0].Rows)
            //{
            //    comboBox3.Items.Add(dr["CityName"]);
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = courseregestration.getstatename(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables["TableState"];
            comboBox2.DisplayMember = "StateName";

        }
    }
}
