using Microsoft.AspNetCore.Mvc;

namespace radiobutton.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
