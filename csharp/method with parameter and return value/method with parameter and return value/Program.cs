using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_with_parameter_and_return_value
{
    class addition
    {
        public int add(int num1,int num2)
        {
            int result=num1 + num2;
            return result;


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            addition s = new addition();
            int a = 10;
            int b = 20;
            int c=s.add(a,b);
            Console.WriteLine("addition is "+c);
            Console.ReadLine();

        }
    }
}
