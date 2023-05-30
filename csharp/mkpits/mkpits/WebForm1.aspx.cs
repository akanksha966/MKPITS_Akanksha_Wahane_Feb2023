using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mkpits
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            int n2 = 0;
            int result = 0;
            n1=Convert.ToInt32(TextBox1.Text);
            n2=Convert.ToInt32(TextBox2.Text);
            result=n1 + n2;
            Label1.Text=result.ToString();
            clearall();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            int n2 = 0;
            int result = 0;
            n1 = Convert.ToInt32(TextBox1.Text);
            n2 = Convert.ToInt32(TextBox2.Text);
            result = n1 - n2;
            Label1.Text = result.ToString();
            clearall();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            int n2 = 0;
            int result = 0;
            n1 = Convert.ToInt32(TextBox1.Text);
            n2 = Convert.ToInt32(TextBox2.Text);
            result = n1 * n2;
            Label1.Text = result.ToString();
            clearall();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            int n2 = 0;
            int result = 0;
            n1 = Convert.ToInt32(TextBox1.Text);
            n2 = Convert.ToInt32(TextBox2.Text);
            result = n1 / n2;
            Label1.Text = result.ToString();
            clearall();
        }
        public void clearall()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}