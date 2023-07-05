using MVC2nd_project.Models;
using System.Web.Mvc;

namespace MVC2nd_project.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.StudentList = "students list";
            StudentDBhandler bhandler = new StudentDBhandler();
            ModelState.Clear(); 

            return View(bhandler.GetStudents());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentModel b)
        {
            if (ModelState.IsValid)
            {
                StudentDBhandler dB = new StudentDBhandler();
                if (dB.StudentList(b))
                {
                    ViewBag.message = "record Saved Successfully";
                    ModelState.Clear();

                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            StudentDBhandler db = new StudentDBhandler();
            return View(db.GetStudents().Find(model=>model.ID == id));  


        }
        [HttpPost]
        public ActionResult Edit(int id,StudentModel model)
        {
            try
            {



                StudentDBhandler db = new StudentDBhandler();
                db.studentupdate(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            StudentDBhandler handler = new StudentDBhandler();
            return View(handler.GetStudents().Find(itemmodel => itemmodel.ID == id));
        }
        [HttpPost]
        public ActionResult Delete(int id, StudentModel model)
        {
            try
            {
                StudentDBhandler db = new StudentDBhandler();
                db.DeleteItem(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }

        }


        public ActionResult Details(int id)
        {
            StudentDBhandler handler = new StudentDBhandler();
            return View(handler.GetStudents().Find(itemmodel => itemmodel.ID == id));
        }



    }
}