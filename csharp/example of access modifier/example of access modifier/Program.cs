using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_of_access_modifier
{
    class animal
    {
        string name;
        int count;
        public void printstatement()
        {
            Console.WriteLine("name is " + name);///do not use private accesss modifier on other class
            Console.WriteLine("count is " + count);
        }

        static void Main(string[] args)
        {
            animal animal = new animal();
            animal.name = "lion";
            animal.count = 4;
            animal.printstatement();
            Console.ReadLine();

        }
        //internal class Program
        //{
           // static void Main(string[] args)
            //{
               // animal animal = new animal();
                //animal.name = "hsksks";
            //}
        //}
    }
}

