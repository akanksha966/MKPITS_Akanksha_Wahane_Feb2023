using create_textbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace create_textbox.Controllers
{
    public class PercentageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PercentStud p)
        {
            ViewBag.Maths = p.Maths;
            ViewBag.Science = p.Science;
            ViewBag.English = p.English;
            ViewBag.SST = p.SST;
            ViewBag.Hindi = p.Hindi;

            p.total = p.Maths + p.Science + p.English + p.SST + p.Hindi;
            p.percent = (p.total / 500.0f) * 100.0f;
            ViewBag.total = p.total;
            ViewBag.percent = p.percent;
            if (p.percent >= 90 && p.percent < 100)
            {
                p.grade = "A++";
            }
            else if (p.percent >= 70 && p.percent < 90)
            {
                p.grade = "A";
            }
            else if (p.percent >= 60 && p.percent < 70)
            {
                p.grade = "B";
            }
            else if (p.percent < 60)
            {
                p.grade = "Fail";
            }
            ViewBag.grade = p.grade;
            return View();
        }
    }
}
