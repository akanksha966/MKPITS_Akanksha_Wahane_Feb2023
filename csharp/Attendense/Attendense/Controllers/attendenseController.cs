using Attendense.Models;
using Microsoft.AspNetCore.Mvc;

namespace Attendense.Controllers
{
    public class attendenseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AttendenceModel model)
        {
            ViewBag.dotnet = model.dotnet;
            ViewBag.java = null;
            ViewBag.Akanksha = "Akanksha";
            ViewBag.Mahesh = "Rupali";
            ViewBag.Sherya = "Sherya";
            ViewBag.Tanu = "Tanushree";
            ViewBag.Mayuri = "Mayuri";










            if (model.Akanksha == true)
            {
                model.value = model.Akanksha.ToString();
                ViewBag.value = "Akanksha";
            }
            else if (model.Akanksha == false)
            {
                model.Absent = model.Akanksha.ToString();
                ViewBag.absent = "Akanksha";

            }

            if (model.Rupali == true)
            {
                model.value1 = model.Rupali.ToString();
                ViewBag.value1 = "Rupali";
            }
            else if (model.Rupali == false)
            {
                model.Absent1 = model.Rupali.ToString();
                ViewBag.absent1 = "Rupali";

            }
            if (model.Sherya == true)
            {
                model.value2 = model.Sherya.ToString();
                ViewBag.value2 = "Sherya";
            }
            else if (model.Sherya == false)
            {
                model.Absent2 = model.Sherya.ToString();
                ViewBag.absent2 = "Sherya";

            }
            if (model.Tanu == true)
            {
                model.value3 = model.Tanu.ToString();
                ViewBag.value3 = "Tanushree";
            }
            else if (model.Tanu == false)
            {
                model.Absent3 = model.Tanu.ToString();
                ViewBag.absent3 = "Tanushree";

            }
            if (model.Mayuri == true)
            {
                model.value4 = model.Mayuri.ToString();
                ViewBag.value4 = "Mayuri";
            }
            else if (model.Mayuri == false)
            {
                model.Absent4 = model.Mayuri.ToString();
                ViewBag.absent4 = "Mayuri";

            }
            if (model.Mayuri == true && model.Tanu == true && model.Akanksha == true && model.Rupali == true && model.Sherya == true)
            {
                ViewBag.details = "No one is Absent";
            }
            else if (model.Mayuri == false && model.Tanu == false && model.Akanksha == false && model.Rupali == false && model.Sherya == false)
            {
                ViewBag.detail2 = "No one is Present";
            }
            ViewBag.percent1 = null;
            ViewBag.percent2 = null;
            ViewBag.percent3 = null;
            ViewBag.percent4 = null;
            ViewBag.percent5 = null;
            ViewBag.percent = null;





            
            //"percent code";
            //for(int i = 0; i<model.count;i++)
            //{
            //    if (model.Mayuri == true || model.Tanu == true || model.Akanksha == true || model.Rupali == true || model.Sherya == true)
            //    {
            //      ViewBag.count=ViewBag.count+1;    
            //    }


            //}
            //if(model.Mayuri == true)
            //{
                
            //}

            return View();  

        }
    }
}
