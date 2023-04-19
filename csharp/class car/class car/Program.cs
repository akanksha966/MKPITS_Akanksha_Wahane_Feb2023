using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_car
{
    internal class Program
    {

        class car
        {
            public string name;
            public string color;
            public int price;
            public string carno;

          

        }
        static void Main()
        {

            car stud= new car();
            stud.name = "ashu";
            stud.color = "blue";

            stud.price = 2000000;
            stud.carno ="ASP234578G";
            Console.WriteLine("rno " + stud.name);
            Console.WriteLine("color" + stud.color);
            Console.WriteLine("price " + stud.price);
            Console.WriteLine("car no" + stud.carno);
            Console.ReadLine();






        }
    }
}
