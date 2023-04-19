using System;


namespace pass_by_reference
{
     class Program
    {
        static void Main()
        {

            int radius; float area, cir;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 0.0f;
            cir = 0.0f;
            calculatearea(radius, ref area, ref cir);
            Console.WriteLine("area " + area);
            Console.WriteLine("circumference" + cir);
            Console.ReadLine();
        }
        static void calculatearea(int r,ref float a,ref float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f* r;
        }
        }
    }

