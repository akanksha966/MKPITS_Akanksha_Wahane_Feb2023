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
namespace example2_without_class_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string abc = "server=.\\sqlexpress;integrated security=true;database=abcd;";
            SqlConnection c=new SqlConnection(abc);
            try
            {
                c.Open();
                label1.Text = "connection done";
            }
            catch (Exception ex) 
            { 
                label1.Text = ex.Message;   
            }
            finally { c.Close(); }
        }
    }
}
