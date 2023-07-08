using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace using_View_Model.Models
{
    public class Teacher
    {

        public int TeacherId { get; set; }
        public string Code { get; set; }
        public string TeacherName { get; set; }
        //list<teacher>is a generic collection

        //generic collection me batana pdta ke konsa coollection bna rahe hai 
        //jiase int float to ham bna rhe student ka generic collection
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher { TeacherId = 1, Code = "TT", TeacherName = "Tegas Trivedi" });
            teachers.Add(new Teacher { TeacherId = 2, Code = "JT", TeacherName = "Jignesh Trivedi" });
            teachers.Add(new Teacher { TeacherId = 3, Code = "RT", TeacherName = "Rakesh Trivedi" });
            return teachers;


        }


    }
}