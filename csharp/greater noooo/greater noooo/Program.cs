using System;


namespace Numbers
{
     class Program
    {
        static void Main()
        {

            int s1, s2,s3;
            
           
            Console.WriteLine("enter num1 ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2 ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter num 3");
            s3= Convert.ToInt32(Console.ReadLine());

            if (s1 > s2 && s1 > s3)
            {

                Console.WriteLine("s1 is greater");
            }
            else if (s2 >s3)
            {
                Console.WriteLine("s2 is greater");
            }
            else
            {
                Console.WriteLine("s3 is greater");
              
            }
            Console.ReadLine();

        }

        }

    }

