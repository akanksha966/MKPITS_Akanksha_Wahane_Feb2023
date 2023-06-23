using Microsoft.AspNetCore.Mvc;

namespace mvcexp1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
