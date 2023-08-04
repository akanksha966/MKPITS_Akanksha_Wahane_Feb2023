using RestaurantWebApplication3.Models;
using RestaurantWebApplication3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantWebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private  readonly RestaurantModel1 model1;
        public HomeController()
        {
            model1 = new RestaurantModel1();

        }



        // GET: Home
        public ActionResult Index()
        {
            CustomerRepository objcustomerRepository = new CustomerRepository();

            ItemRepository objitemRepository = new ItemRepository();

            PaymentRepository objpaymentRepository = new PaymentRepository();
            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (objcustomerRepository.obj(), objitemRepository.obj(), objpaymentRepository.obj());
            return View(objMultipleModels);



        }

        [HttpGet]

        public JsonResult getItemUnitPrice(int itemId)
        {
            decimal UnitPrice = (decimal)model1.Items.Single(model => model.ItemId == itemId).ItemPrice;
            return Json(UnitPrice, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index(OrderViewModel objOrderViewModel)
        {



            OrderRepository objorderRepository = new OrderRepository();
            objorderRepository.AddOrder(objOrderViewModel);
            return Json(" Your Order Has Been Successfully Placed....", JsonRequestBehavior.AllowGet);
        }

    }
}