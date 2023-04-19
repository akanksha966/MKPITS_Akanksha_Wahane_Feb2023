using System;

namespace prime
{
     class Program
    {
        static void Main()
        {
            for (int outercounter = 1; outercounter <= 20; outercounter++)
            {




                int num = outercounter;

                int counter;
                int flag = 0;
                for (counter = 2; counter < num; counter++)
                {
                    if (num % counter == 0)
                    {
                        flag = 1;
                        break;
                    }
                }


                    if (flag == 0)
                    {
                        Console.WriteLine(num+ "it is a prime no");
                        Console.ReadLine();

                    }
                    

                }
                

            }


        }
    
}
