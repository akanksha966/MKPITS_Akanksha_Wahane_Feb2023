using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding_revision
{
    class animal
    {
        public void dog(int a,int b)
        {
            Console.WriteLine("my name is dog");//method overriding has the same parameter or empty



        }


    }

    class cat:animal {
        public void dog()//use can use the parameter should be same
        {
            Console.WriteLine("my name is cat");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            animal cat = new animal();
            cat.dog(1,2);
            cat cat2 = new cat();

            cat2.dog(1, 2);
            Console.ReadLine();




        }
    }
}
