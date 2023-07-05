using Microsoft.AspNetCore.Mvc;
using mvcproject1.Models;

namespace mvcproject1.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ItemModel Ilist)
        {
              if(ModelState.IsValid)
            {
                ItemDBHandler db=new ItemDBHandler();
                if(db.InsertItem(Ilist))
                {
                    ViewBag.message = "Item Saved Successfully";
                    ModelState.Clear();
                }
            }
              return View();
        }
        

    }
}
