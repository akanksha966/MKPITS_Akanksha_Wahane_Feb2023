using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2nd_project.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string SName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Course { get; set; }

        public int AddmissionFee { get; set; }
        public string Duration { get; set; }
        public DateTime date { get; set; }  
        public int phoneno { get; set; }


    }
}