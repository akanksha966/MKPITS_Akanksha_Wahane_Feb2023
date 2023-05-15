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
namespace without_cstatic_classs_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "server=.\\sqlexpres;integrated security=true;database=abcd;";
            SqlConnection c = new SqlConnection(con);
            try
            {
                c.Open();
                label1.Text = "connect successfully";



            }
            catch (Exception ex)
            {
                label1.Text = "not connect";
            }
            finally
            { c.Close(); }
        }
    }
}