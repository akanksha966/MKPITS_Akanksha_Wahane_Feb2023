using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace operator_using_windows
{
    public partial class Operators : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1=0;
            int num2=0;
            int res=0;
            string op;
             num1 = Convert.ToInt32(TextBox1.Text);
            num2=Convert.ToInt32(TextBox2.Text);
            op = TextBox3.Text;
            if(op=="+")
            {
                res=num1 + num2;    
            }
            else if(op=="-") { 
                res=num1 - num2;    
            }

            else if (op == "*")
            {
                res = num1 - num2;
            }

            else if (op == "/")
            {
                res = num1 - num2;
            }

            Label1.Text=res.ToString();





        }
    }
}