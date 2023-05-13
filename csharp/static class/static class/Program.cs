using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    public static class person
    {
         public static int id;
        public static string name;
        public static void info()
        {
            id = 0;
            name = "ashu";
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("id is " + person.id);
            Console.WriteLine("name is " + person.name);
            Console.ReadLine();
        }
    }
}
