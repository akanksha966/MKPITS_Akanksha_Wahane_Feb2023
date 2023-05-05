using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritance_using_interface
{
    interface Iepmloyee
    {
        void method();
    }

    class parttime : Iemployee
    {
        public void method()
        {
            Console.WriteLine("it is interface method");
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            parttime parttime = new parttime();
            parttime.method();
            Console.ReadLine();
        }
    }
}


