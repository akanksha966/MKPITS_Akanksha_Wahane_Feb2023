using System;

namespace laptop
{
    class Program
    {
        static void Main()
        {
            string productname;
            Console.WriteLine("enter product name");
            productname = Console.ReadLine();


            int quantity, rate, totalamount;
            float discount,finalbill;

            Console.WriteLine("enter deposit");
            rate = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter quantity");
            quantity = Convert.ToInt32(Console.ReadLine());

            totalamount = rate * quantity;


            if (totalamount > 2000)
            {
                discount = totalamount * 0.5f/100;

                Console.WriteLine("Total discount is" + discount);
                finalbill = totalamount - discount;
                    Console.WriteLine("Your final bill is" + finalbill);

                Console.ReadLine();

            }

            

           
            else
            {
                discount = totalamount * 0.1f / 100;
                Console.WriteLine("Total disconut is" +discount);
                finalbill = totalamount - discount;
                    Console.WriteLine("Your final bill is" + finalbill);

                Console.ReadLine();




            }







        }
    }
}
