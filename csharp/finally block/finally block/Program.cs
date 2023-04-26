using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor_revision
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 2;//finally block example 
            int res = 0;
            try
            {
                res = n1 / n2;
                Console.WriteLine("result is " + res);//get block
            }
            catch (DivideByZeroException ee)//catch block
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.WriteLine("finally executed");
            }
            Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
}
