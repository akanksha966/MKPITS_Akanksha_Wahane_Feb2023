using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_order
{
    class order
    { 
    public string name;
       
        public int amount;  
        public int quantity;
           public int total;
           


    internal class Program
    {
            static void Main(string[] args)
            {
                order stud = new order();

                stud.name = "idali";

                stud.amount = 100;
                stud.quantity = 2;
                stud.total = 100 * 2;
                Console.WriteLine("enter dish name" + stud.name);
                Console.WriteLine("enter amount" + stud.amount);
                Console.WriteLine("enter quantity" + stud.quantity);
                Console.WriteLine("total" + stud.total);
                Console.ReadLine();
            }


            }
        }
}
