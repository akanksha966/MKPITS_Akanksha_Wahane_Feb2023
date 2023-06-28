using bankexampleusingdropdown.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace bankexampleusingdropdown.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(account a)
        {
            int bal = 10000;
            int actno = a.Accountno;
            int amount = a.amount;
            var tt = a.gettranstype;
            string tt1=tt.ToString();
             
                switch (tt1)
                 {
                case "deposit":
                    bal = bal + amount;
                    break;
                case "withdrawl":
                    bal=bal - amount;
                    break;


            }
            ViewBag.accountno = actno;
            ViewBag.balance = bal;
            return View();   
        }
    }
}
