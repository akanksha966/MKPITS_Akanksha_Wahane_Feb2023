using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace class_employee2_using_function
{
    class employee
    { 

    public int id;
    public string name;
        public int age;
        public float salary;


        public void getdata(int i,string n,int c,float s)
        {
            id = i;
            name = n;
            age = c;
            salary = s;
        }


        public void display()
        {
            Console.WriteLine("id is " + id);
            Console.WriteLine("name is " + name);
            Console.WriteLine("age is " + age);
            Console.WriteLine("salary is " + salary);
            Console.ReadLine();


        }
        internal class Program
        {
            static void Main(string[] args)
            {

                employee stud = new employee();

                Console.WriteLine("enter id");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter name");
                string name = Console.ReadLine();

                Console.WriteLine("enter salary");
                float salary = Convert.ToInt32(Console.ReadLine());

                stud.getdata(id,name,age,salary);
                stud.display();
            

            

            }
        } 
    }
}
