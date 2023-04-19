using System;

namespace circle_circum
{
    class Program
    {
        static void Main()
        {

            int radius;
            float area, cirs;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
             area = 3.14f * radius * radius;
            Console.WriteLine("area = " + area);
             cirs= 2 * 3.14f * radius;
            Console.WriteLine("circ = " + cirs);
            Console.ReadLine();
        }
    }

    }

