using checkbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace checkbox.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CheckModel model)
        {

            if (model.tea == true)
                ViewBag.Tea = "you selected Tea";
            if (model.Loundary == true)
                ViewBag.Loundry = "you selected Loundry";
            if (model.Breakfast== true)
                ViewBag.Breakfast = "you selected breakfast";
            return View();
        }
        }
    }

