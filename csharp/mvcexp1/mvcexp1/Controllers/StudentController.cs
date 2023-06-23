using Microsoft.AspNetCore.Mvc;

namespace mvcexp1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
