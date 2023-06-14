using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using banklibrary;

namespace bankusingclass
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 s = new Class1();
            Label1.Text=s.withdraw(Convert.ToInt32(TextBox1.Text));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 s = new Class1();
            Label1.Text = s.deposit(Convert.ToInt32(TextBox1.Text));
        }
    }
}