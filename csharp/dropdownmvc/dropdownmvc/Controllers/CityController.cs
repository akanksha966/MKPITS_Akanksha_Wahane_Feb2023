using dropdownmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dropdownmvc.Models;

namespace dropdownmvc.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details()
        {
            bindstate();
            return View();
        }
        public void bindstate()
        {
            DataModel model= new DataModel();
            var state=model.Statetables.ToList();//statetables is table name
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "---Select State---", Value = "0" });
            foreach(var m in state)
            {
                list.Add(new SelectListItem { Text=m.statename,Value=m.stateid.ToString()});
                ViewBag.state = list;
            }

        }


        public JsonResult getCity(int id)
        {
            DataModel modelDemo = new DataModel();
            var ddlCity = modelDemo.Citytables.Where(x => x.stateid == id).ToList();
            List<SelectListItem> licities = new List<SelectListItem>();

            licities.Add(new SelectListItem { Text = "--Select State--", Value = "0" });
            if (ddlCity != null)
            {
                foreach (var x in ddlCity)
                {
                    licities.Add(new SelectListItem { Text = x.cityname, Value = x.Cityid.ToString() });
                }
            }
            return Json(new SelectList(licities, "Value", "Text", JsonRequestBehavior.AllowGet));
        }

    }

}
