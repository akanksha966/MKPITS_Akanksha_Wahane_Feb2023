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

namespace fromsdatabse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=joins;";
            SqlConnection con=new SqlConnection(constr);
            try
            {
                con.Open();
                label1.Text = "connection successfull";
            }
            catch(Exception ee)
            {
                label1.Text = ee.ToString();
            }
            finally { 
                con.Close();
            }
            
                
            

        }
    }
}
