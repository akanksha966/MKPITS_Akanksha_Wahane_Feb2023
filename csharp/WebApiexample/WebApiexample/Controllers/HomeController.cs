using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiexample.Models;

namespace WebApiexample.Controllers
{
    public class HomeController : ApiController
    {
        Employee[] employees = new Employee[] {

            new Employee { ID = 1, Name = "ashuu", JoiningDate = DateTime.Parse(DateTime.Today.ToString()), Age = 22 },
            new Employee { ID = 2, Name = "akanksha", JoiningDate = DateTime.Parse(DateTime.Today.ToString()), Age = 27 }

        };

        //creating a method getallemployees to return list of employees details
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees; //employees is array of object created above
        }
    }


}
