using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throw_block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("enter age ");
                age = Convert.ToInt32(Console.ReadLine());
                if(age<=0 || age>=100)
                {
                    throw new Exception("enter proper age");
                }
                else
                {
                    Console.WriteLine("your age is " + age);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
}
