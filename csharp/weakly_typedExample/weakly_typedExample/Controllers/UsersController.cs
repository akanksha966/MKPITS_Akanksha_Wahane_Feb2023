using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace weakly_typedExample.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult form1(int txtId,string txtName,string chkgender)
        {
            ViewBag.txtId = txtId;
            ViewBag.txtName = txtName;
            if (chkgender != null )
            {
                ViewBag.gender = "selected successfully";
            }
            else
            {
                ViewBag.gender = "selected unsuccessfully";

            }


            return View("Index");
        }
    }
}