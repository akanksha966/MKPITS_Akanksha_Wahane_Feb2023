using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aplicationvariable_and_session_variable
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int usercounter = (int)Session["usercount"];
            usercounter=usercounter+1;
            Session["usercount"]=usercounter;
            Response.Write("user session count" + usercounter);
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session ["username"]=TextBox1.Text;
            Session["email"]=TextBox2.Text;
            Label1.Text = "value stored in session variable";


            //sesssion varible me store krenge textbox ke value


        }
    }
}