using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierachical_inheritance
{

    class person
    {
        public string name;
        public string address;


        public void getdata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);
        }
    }


    class student : person
    {
        public int id;
        public int marks;

        public void getdata2(int rno,int marks)
        {
            this.id = rno;
            this.marks = marks;
        }

        public void display2()
        {
            Console.WriteLine("name : " + id);
            Console.WriteLine("address : " +marks);
        }
            
            
    }

    class employee : person
    {
        public int salary;
        public string designation;

        public void getdisplay3(int salary,string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void display3()
        {

            Console.WriteLine("name : " + salary);
            Console.WriteLine("address : " + "manager");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();

            s.getdata("ashu", "gaytri mandir");
            s.getdata2(4152,200);

            s.display();
            s.display2();

            ////creating object of empclass
            ///

            
            Console.ReadLine();



        }
    }
}
