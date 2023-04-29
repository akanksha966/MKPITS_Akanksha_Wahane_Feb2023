using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_3_add
{
    internal class Program
    {
        static void Main()
        {
            int[] num = { 1, 2, 2, 4, 3, 7, 4, 3 };
            
            int sum=0;
            for(int i=0; i<num.Length; i++)
            {

                if (num[i] == 1)

                {
                    Array.Clear(num, 0, 0);

                }


                else
                {

                    sum = sum + num[i];
                }


                    }
            Console.Write("total sum is " + sum);

            Console.ReadLine();


        }



    }
        }
    
