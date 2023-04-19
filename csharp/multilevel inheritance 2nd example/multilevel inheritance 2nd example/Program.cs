using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace multilevel_inheritance_2nd_example
{


    public class person
    {
        string name;
        string address;
        public void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }
    }

    public class student : person
    {
        int rno;
        int marks;
        public void getstudentdata(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void studentdata()
        {
            Console.WriteLine("name : " + rno);
            Console.WriteLine("address : " + marks);
        }
    }

    public class parttime : student
    {
        int salary;
        string designation;
        public void getEmployeeData(int salary, String designation)
        {
            this.salary = salary;
            this.designation = designation;
        }

        public void displayEmployeeData()
        {
            // displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("salary : " + salary);
            Console.WriteLine("designation : " + designation);


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parttime stud= new parttime();
            stud.getpersondata("ashu", "gaytri mandir");
            stud.getstudentdata(12, 4444);
            stud.getEmployeeData(1000, "manager");
            stud.displayPersonData();
            Console.ReadLine();
          
        }
    }
}
