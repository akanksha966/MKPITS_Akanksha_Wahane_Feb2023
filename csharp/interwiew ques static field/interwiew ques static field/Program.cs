using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interwiew_ques_static_field
{
    class person
    {
        public int id;  
        public int age;
        public static float salary=10000;

        public person(int id1,int age2)
        {
            id = id1;
            age = age2;
            Console.WriteLine("id is "+id);
            Console.WriteLine("age is "+age);
            Console.WriteLine("salary is " + salary);
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person p= new person(23,56);
            person p2 = new person(23, 56);


        }
    }
}
