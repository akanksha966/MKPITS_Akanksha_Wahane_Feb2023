using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prrime_no_using_recursion
{

    class Program
    {
        
        public int prime(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("number is not prime");
                return 1;
            }
            else
            {


                Console.WriteLine("number is prime "+num);
                prime(num);
              
                return num;
            }
            }
            

          static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Program obj= new Program(); 
            int result= obj.prime(num);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

