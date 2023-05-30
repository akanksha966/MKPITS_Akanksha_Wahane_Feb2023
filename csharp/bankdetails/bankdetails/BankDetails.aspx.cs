using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bankdetails
{
    public partial class BankDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int amount = 1000;

            int Addamount =Convert.ToInt32(TextBox2.Text);
            int totalbalance = 0;
            string acttype=TextBox3.Text;
            if(acttype =="Withdraw")
            {
                totalbalance = amount - Addamount;  
            }
            else if(acttype =="deposit")
            {
                totalbalance=amount + Addamount;
            }
           Label1.Text=totalbalance.ToString();
            clearall();
           
        }
        public void clearall()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }
    }
}