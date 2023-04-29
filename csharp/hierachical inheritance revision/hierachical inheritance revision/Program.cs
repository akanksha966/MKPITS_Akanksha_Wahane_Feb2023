using single_level_revision_exp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace single_level_revision_exp
{
    class car
    {
        public string model;
        public string color;
        public int price;

        //method create
        public void printinfo()//method
        {
            Console.WriteLine("model is " + model);
            Console.WriteLine("color is " + color);
            Console.WriteLine("price is " + price);
        }
    }
    class ferari : car //class ferari inherit car
    {
        public int speed;
        public void printspeed()//methd
        {
            Console.WriteLine("speed is " + speed);//multilevel inheritance

        }
    }
    class maruti : car
    {
        public float mileage;
        public void printmileage()
        {
            Console.WriteLine("milage is " + mileage);

        }

    }




}



internal class Program
{
    static void Main(string[] args)
    {

        maruti maruti = new maruti();
        maruti.model = "alto";
        maruti.color = "blue";
        maruti.price = 1000000;
        maruti.mileage = 22.45f;
        maruti.printinfo();
        maruti.printmileage();
        ferari ferari = new ferari();//ferrari class object beacuse ham class car ko inherit kr rhe na ke
                                     //ferari class ko inherit kr rhe maruti class me
                                     //or maruti inherit kr rhi ferrai class
        ferari.speed= 100;  
        ferari.printspeed();
        Console.ReadLine();

    }
}

