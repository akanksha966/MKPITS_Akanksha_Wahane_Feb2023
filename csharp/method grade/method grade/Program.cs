using System;
using System.Xml.Schema;

namespace add_sub_method
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter subject 1 marks");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter subject 2 marks");

            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter subject 3 marks");

            int num3 = Convert.ToInt32(Console.ReadLine());


            int result = calculate(num, num2, num3);
            Console.WriteLine("total " + result);

            Console.ReadLine();
        }
        static int calculate(int number, int number2, int number3)
        {
            int flag = 0;
            if (flag == 0)
            {

                int total;
                

                total = number + number2 + number3;



                
            }
            else if(flag == 1)
            {
                int percent;
                perccent = total / 300 * 100;
            }








        }








    }


    }

