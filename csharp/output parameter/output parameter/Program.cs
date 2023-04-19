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
           
            
            calculatearea(radius, out area, out cir);
            Console.WriteLine("area " + area);
            Console.WriteLine("circumference" + cir);
            Console.ReadLine();
        }
        static void calculatearea(int r, out float a, out float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
    }
}

