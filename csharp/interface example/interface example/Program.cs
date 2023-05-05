using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_example
{
    interface Iemployee
    {
        void method();
    }
    class class1
    {
       public void basemethod()
        {
            Console.WriteLine("it is a base class");
        }
    }
    class class2 : class1, Iemployee
    {
        public void method()
        {
            Console.WriteLine("it is interface class");
        }
        
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            class2 class1 = new class2();
            class1.basemethod();
            class1.method();
            Console.ReadLine();
        }
    }
}
