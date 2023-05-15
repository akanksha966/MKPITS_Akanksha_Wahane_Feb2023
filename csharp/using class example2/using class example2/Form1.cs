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
namespace using_class_example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection s=Database.GetConnection();
            if (s != null )
            {
                label1.Text = "successfully";
                s.Close();
            }
            else
            {
                label1.Text = "unsuccessfull";
            }


        }
    }
}
