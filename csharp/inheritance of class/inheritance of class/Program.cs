using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_of_class
{

    class person/////base class
    {
        public string name;
        public int age;
    }

        class student:person/////child classs
        {
            public int id;
            public int rno;


        }


    
    internal class Program
    {
        static void Main(string[] args)
        {

            student info = new student();

            info.name = "akanksha";
            info.age = 23;
            info.id = 1234;
            info.rno = 2;

            Console.WriteLine("name is " + info.name);
            Console.WriteLine("age is " + info.age);
            Console.WriteLine("id is " + info.id);
            Console.WriteLine("roll number is " + info.rno);
            Console.ReadLine();
        }
        }
    }

