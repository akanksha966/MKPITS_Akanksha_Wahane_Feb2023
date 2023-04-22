using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_para_not_return_value
{
    class addition
    {
        public void add(int num1,int num2)
        {
            int result=num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            addition s = new addition();
            s.add(7, 8);
        }
    }
}
