using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aplicationvariable_and_session_variable
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string companyname = (string)Application["companyname"];
           Label1.Text = companyname;

            string Address = (string)Application["Address"];
            Label2.Text = Address;

            int counter = (int)Application["counter"];
            counter = counter + 1;
            Application["counter"] = counter;
            Label4.Text = "You are visitor no" + counter.ToString();


        }
    }
}