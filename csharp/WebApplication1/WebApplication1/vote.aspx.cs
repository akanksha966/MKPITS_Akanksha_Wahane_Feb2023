using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class vote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(TextBox1.Text);
            if(age<18)
            {
                Label1.Text = "your not eligible for vote";
            }
            else
            {
                Label1.Text="your eligible for vote";
            }
        }
    }
}