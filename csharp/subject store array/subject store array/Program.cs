using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject_store_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine("enter subject 1 marks");
                arr[0] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter subject 2 marks");
                arr[1] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter subject 3 marks");
                arr[2] = Convert.ToInt32(Console.ReadLine());
                break;

            }

            for (int i = 0; i < arr.Length; i++)
            {

                int total = arr[0] + arr[1] + arr[2];


                Console.WriteLine("total is "+total);

                float per = total / 300f * 100;
                Console.WriteLine("percentage is " + per);
                
                if(per>=80)
                {
                    Console.WriteLine("Distinction");

                }


                else if (per <= 60)
                {
                    Console.WriteLine("first class");

                }
                else
                {
                    Console.WriteLine("Fail");


                }


                Console.ReadLine();

            }
        }
    }
}
