using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace custom_validator_control
{
    public partial class custom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //first add a code of config file jo nye project bnaye usme sab me krna hai
      

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string val=args.Value;//custom validate
            int len=args.Value.Length;
            if (len == 10)
            {
                string d = val.Substring(0, 2);//date length 3
                int dd = Convert.ToInt32(d);
                if (dd > 31)
                {
                    args.IsValid = false;
                }
                else
                {
                    string m = val.Substring(3, 2);
                    // Response.Write("month" + m);
                    int mm = Convert.ToInt32(m);
                    if (mm > 12)//month
                    {
                        args.IsValid = false;
                    }

                    else
                    {
                        string y = val.Substring(6, 4);
                        // Response.Write(&quot;yy &quot; + y);
                        //int mm = Convert.ToInt32(y);
                        int yl = y.Length;
                        if (yl == 4)
                        {
                            args.IsValid = true;//year
                        }
                        else
                        {
                            args.IsValid = false;
                        }
                    }

                }
            }


            else
            {
                args.IsValid = false;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Label1.Text = TextBox1.Text;
            }
            else
            {
                Label1.Text = "page is not valid";
            }
        }
    }
}