using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision_of_static_classs
{
    public static class animal
    {
        public static void display()
        {
            Console.WriteLine("hello static class");
            Console.ReadLine();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
          animal.display(); 
            
        }
    }
}
