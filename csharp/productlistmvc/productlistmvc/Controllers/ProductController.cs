using Microsoft.AspNetCore.Mvc;
using productlistmvc.Models;

namespace productlistmvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(productname k)
        {
            ViewBag.Name=k.Name; 
            ViewBag.pprice = k.pprice;
            ViewBag.quantity = k.quantity;
            ViewBag.totalprice = k.pprice * k.quantity;
            return View();

        }
    }
}
