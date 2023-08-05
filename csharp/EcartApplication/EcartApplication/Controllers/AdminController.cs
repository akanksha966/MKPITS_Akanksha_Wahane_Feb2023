using EcartApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Microsoft.Ajax.Utilities;
using System.Data.Entity;

namespace EcartApplication.Controllers
{

    public class AdminController : Controller
    {
        Model1 m = new Model1();
        // GET: Admin
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(tbl_admin admin)
        {
            //tbl_admin ad = tbl_admin.Where(x => x.== admin.AdminUsername && x=>x == admin.AdminPassword).SingleOrDefault();
            tbl_admin ad = m.tbl_admin.Where(x => x.AdminUsername == admin.AdminUsername && x.AdminPassword == admin.AdminPassword).SingleOrDefault();
            //m is model name and tbl_admin table name
            if (ad != null)
            {

                Session["AdminId"] = ad.AdminId.ToString();
                
                return RedirectToAction("Create");

            }
            else
            {
                ViewBag.error = "Invalid username or password";

            }

            return View();


        }


        public ActionResult Create()
        {

            if (Session["AdminId"] == null)
            {
                return RedirectToAction("login");
            }
            return View();
        }




        [HttpPost]
        public ActionResult Create(tbl_Categorry1 cvm, HttpPostedFileBase imgfile)
        {
            string path = uploadimgfile(imgfile);
            if (path.Equals("-1"))
            {
                ViewBag.error = "Image Could Not Be Uploaded.....";
            }
            else
            {
                tbl_Categorry1 cat = new tbl_Categorry1();
                cat.CategoryName = cvm.CategoryName;
                cat.CategoryImage = path;
                cat.Category_Status = 1;
                cat.Category_admin = Convert.ToInt32(Session["AdminId"].ToString());
                m.tbl_Categorry1.Add(cat);
                m.SaveChanges();
                return RedirectToAction("Create");
            }

            return View();
        }
        public string uploadimgfile(HttpPostedFileBase file)
        {
            Random r = new Random();
            string path = " -1 ";
            int random = r.Next();
            if (file != null && file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName);
                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/upload"), random + Path.GetFileName(file.FileName));
                        file.SaveAs(path);
                        path = "~/Content/upload/" + random + Path.GetFileName(file.FileName);


                    }
                    catch (Exception e)
                    {
                        path = "~/ Content / upload";
                    }
                }


                else
                {
                    Response.Write("<script>alert('Only jpg,jpeg or png formats are acceptable ...........') ;</script>");

                }
            }
            else
            {
                Response.Write("<script>alert('Pls Select A File'); </script>");
                path = " -1 ";
            }
            return path;


        }









    }


}

    

