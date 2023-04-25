using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{
    public class calculate
    {
        public static float pi;
        static calculate()//static constructor
        {
            pi = 3.14f;
            Console.WriteLine("static constructor called");
        }
        public void display()
        {
            Console.WriteLine("rate of interest is " + pi);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate a1 = new calculate();//static constructor yek he bar call hota hai
                                           //chahe kitne bhi object bne ho
            a1.display();
            Console.WriteLine("=========");

            calculate a2 = new calculate();  
            a2.display();
            Console.ReadLine();
        }
    }
}
