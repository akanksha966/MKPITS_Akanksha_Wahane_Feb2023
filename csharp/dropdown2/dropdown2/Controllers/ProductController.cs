using dropdown2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;

namespace dropdown2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            bindstate();
            return View();

        }
        public void bindstate()
        {
            ProductDetails model = new ProductDetails();
            var state = model.TableProducts.ToList();//statetables is table name
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "---Select Product Category---", Value = "0" });
            foreach (var m in state)
            {
                list.Add(new SelectListItem { Text = m.ProductName, Value = m.productid.ToString() });
                ViewBag.state = list;
            }

        }

        public JsonResult getproduct(int id)
        {
            ProductDetails modelDemo = new ProductDetails();
            var ddlCity = modelDemo.TableProductDetails.Where(x => x.productid == id).ToList();
            List<SelectListItem> licities = new List<SelectListItem>();

            licities.Add(new SelectListItem { Text = "--Select ProductName--", Value = "0" });
            if (ddlCity != null)
            {
                foreach (var x in ddlCity)
                {
                    licities.Add(new SelectListItem { Text = x.Product_type_Name, Value = x.productid.ToString() });
                }
            }
            return Json(new SelectList(licities, "Value", "Text", JsonRequestBehavior.AllowGet));
        }



    }
}
    