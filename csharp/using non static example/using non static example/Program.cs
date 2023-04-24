using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_non_static_example
{
    class print
    {
        
        public void print2(int num1,int num2)
        {
            int result=num1 + num2;
            Console.WriteLine("result is "+result);
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            print s = new print();
            s.print2 (3,2);
        }
    }
}
