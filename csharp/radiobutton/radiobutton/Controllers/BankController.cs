using Microsoft.AspNetCore.Mvc;
using radiobutton.Models;

namespace radiobutton.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(bank bank)
        {
            ViewBag.customername=bank.customername;
            ViewBag.amount=bank.amount;
            ViewBag.balance = null ;
            ViewBag.result = null;
            ViewBag.mode = null;
            if(bank.mode=="deposit")
            {
                ViewBag.result=bank.balance+bank.amount;
            }

            if (bank.mode == "withdraw")
            {
                ViewBag.result = bank.balance-bank.amount;
            }
           
            return View();
        }
    }
}
