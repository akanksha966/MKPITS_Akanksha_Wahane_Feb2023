using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddedMultipleModelInSINGLE.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EnrollmentNo { get; set; }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                StudentId = 1,
                Code = "L0001",
                Name = "Amit Gupta",
                EnrollmentNo =
            "201404150001"});
            students.Add(new Student
            {
                StudentId = 2,
                Code = "L0002",
                Name = "Chetan Gujjar",
                EnrollmentNo =
            "201404150002"
            });
            students.Add(new Student
            {
                StudentId = 3,
                Code = "L0003",
                Name = "Bhavin Patel",
                EnrollmentNo =
            "201404150003"
            });
            return students;
        }
    }
}