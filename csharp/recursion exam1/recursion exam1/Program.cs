using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_exam1
{
    internal class Program
    {
        static void Main()
        {
            int fact,num;
            Console.WriteLine("enter number");
            num=Convert.ToInt32(Console.ReadLine());
            Program obj=new Program();
            ///calling recursive function
            fact=obj.factorial(num);

            Console.WriteLine("factorial is " +fact);
            Console.ReadLine();

        }


        public int factorial(int num)
        {
            if(num == 0)
                return 1;
            else

                ////recursive call   b                
                return num*factorial(num-1);

        }



    }
}
