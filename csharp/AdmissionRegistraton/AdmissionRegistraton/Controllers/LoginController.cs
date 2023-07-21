using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdmissionRegistraton.Models;

namespace AdmissionRegistraton.Controllers
{
    public class LoginController : Controller
    {
    

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserTable user)
        {
            if (ModelState.IsValid)
            {
                using (CourseModel model = new CourseModel())
                {
                    var obj = model.UserTables.Where(a => a.Username.Equals(user.Username) && a.Password.Equals(user.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.Id.ToString();
                        Session["UserName"] = obj.Username.ToString();
                        return RedirectToAction("Index", "Home");


                    }
                    else
                    {
                        ModelState.AddModelError("", "The UserName And Password Incorrect ");

                    }



                }
            }
            return View(user);

        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }
            

            









        }
    }
