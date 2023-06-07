using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usemanagement
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email,psw;
            email = Request.QueryString["email"].ToString();
            psw = Request.QueryString["psw"].ToString();

             Response.Write("email :" + email + "<br>");
            Response.Write("psw :" + psw + "<br>");
            //this is called as state management
            //matlab yek page pe value dale dusre page me reterive krna
            //it is used to maintain set


        }
    }
}