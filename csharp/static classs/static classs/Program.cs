using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_classs
{
    public static class calculate
    {
        public static float pi = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pi= "+calculate.pi);
            Console.WriteLine("cube is " + calculate.cube(3));
            Console.ReadLine();
        }
    }
}
