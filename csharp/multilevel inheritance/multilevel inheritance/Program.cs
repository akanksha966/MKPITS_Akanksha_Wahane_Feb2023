using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace multilevel_inheritance
{

    class animal  ///////base classs animal
    {
        string name;

        public void getdata(string name)  /////method
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("enter name " + name);
        }
    }

    class dog:animal     //////dog derived classs of animal
    {
        string gender;

        public void getdata2(string gender)
        {
            this.gender = gender;
        }

        public void display2()
        {
            Console.WriteLine("enter name " + gender);
        }

    }
    class other_animal:dog      ///other_animal derived class of dog
    {
        string dish;

        public void eat(string dish)
        {
            this.dish = dish;
        }

        public void display3()
        {
            Console.WriteLine("enter dish name " + dish);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            other_animal stud= new other_animal();
            stud.getdata("julli");
            stud.display();
            stud.getdata2("female");
            stud.display2();
            stud.eat("Roti");
            stud.display3();

            Console.ReadLine();
        }
    }
}
