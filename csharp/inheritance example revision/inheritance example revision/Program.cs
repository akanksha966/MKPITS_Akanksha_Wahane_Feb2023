using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_example_revision
{
    class car
    {
        protected string model;
        protected string color;
        protected int price;
        protected void printinfo()
        {
            Console.WriteLine("model is " + model);
            Console.WriteLine("color is " + color);
            Console.WriteLine("price is " + price);

        }

    }
    class maruti : car
    {
        protected float mileage;
        public void printmilage()
        {
            Console.WriteLine("milage is " + mileage);
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                maruti maruti = new maruti();
                maruti.model = "mahindra";
                maruti.color = "red";
                maruti.price = 10000;
                maruti.mileage = 22.4f;
                maruti.printinfo();
                maruti.printmilage();
                Console.ReadLine();
            }
        }
    }
}
