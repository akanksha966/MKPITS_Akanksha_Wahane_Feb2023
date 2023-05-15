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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string concr = "server=.\\sqlexpress;integrated security=true;database=joins;";
            SqlConnection con=new SqlConnection(concr);
            try
            {
                con.Open();
                label1.Text = "connection successfull";

            }
            catch(Exception ex)
            {
                label1.Text = ex.ToString();

            } 
            finally { con.Close(); }

            

        }
    }
}
