using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_access_modifier
{
    class car
    {
        protected string name;
        protected void cardata()
        {
            Console.WriteLine("car basic infornamtion to shared or seen publically");
            Console.WriteLine("name is " + name);
        }





        class car2
        {
            protected int price;
            protected void cardata2()
            {
                Console.WriteLine("car basic infornamtion to shared or seen publically");
            }//









            internal class Program
            {
                static void Main(string[] args)
                {
                    car mycar = new car();
                    mycar.name = "maruti";
                    mycar.cardata();

                    car2 myc = new car2();

                    myc.price = 100000;
                    myc.cardata2();
                    Console.ReadLine();


                }

            }
        }
    }
}
    

