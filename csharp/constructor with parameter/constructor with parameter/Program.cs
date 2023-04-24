using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_with_parameter
{
    class car
    {
        public string mycar;
        public int price;
        public car(string a,int b)
        {
            mycar = a;
            price = b;  
            Console.WriteLine("constructor overloading parameter");

        }
        public car(int b,string a)
        {
            mycar += a;
            price = b;
            Console.WriteLine("constructor with parameter");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car stud=new car("aasa",200000);
            //or
            Console.WriteLine("model name is "+stud.mycar);
            Console.WriteLine("model price is " + stud.price);

            Console.ReadLine();
        }
    }
}
