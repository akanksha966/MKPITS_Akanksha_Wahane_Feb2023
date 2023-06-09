using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace aplicationvariable_and_session_variable
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //application event yek he bar fire krta hai mtlab yek he bar codenrun hota hai
            //bad me kb run honga jab server bnd karenge
            ////declare global variable//
            Application["companyname"] = "Mkpits Services";//access global variable on h2 heading down
            Application["Address"] = "IT Park";
            Application["Counter"] = 0;
            //variable ko accssee krna hai to app ko jo page me jna hai vha 

        }
        void Session_Start(object sender, EventArgs e)
        {
            Session["usercount"] = 0;
            Session["username"] = "";
            Session["email"] = "";
        }
    }
}