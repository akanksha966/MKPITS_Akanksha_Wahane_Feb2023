using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace create_a_classs_student
{
    class student
    {
        public int rno;
        public string name;

        //creating member function
        public void getdata(int r,string n)
        {
            rno = r;
            name = n;
        }

        public void displaydata()
        {
            Console.WriteLine("roll no is" + rno);
            Console.WriteLine("name is " + name);
            Console.ReadLine();
        }
    }
    class program
    { 
    
    
        static void Main(string[] args)
        {
            student stud1 = new student();
            Console.WriteLine("enter number");
            int rno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");

            string name = Console.ReadLine();
            stud1.getdata(rno, name);   


            stud1.displaydata();
            

        }
    }
}
