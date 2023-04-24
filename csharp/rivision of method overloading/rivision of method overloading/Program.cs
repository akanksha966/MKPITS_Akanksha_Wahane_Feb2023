using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rivision_of_method_overloading
{
    // method overloading means same method name but different signature 
    class calculator
    {
        public int cal(int x,int y)
        {
            int c=x+y; return c;    


        }

        public int cal(int x, int y,int z)
        {
            int c = x + y+z; return c;


        }
    }
    class abc:calculator
    {
        public int cal(int x, int y, int z)
        {
            int c = x + y + z; return c;


        }
        public int cal(int x, int y)
        {
            int c = x + y; return c;


        }

    }
    //class abc
    //{
        //do not use the same method in different class public int cal()
        //{
          //  Console.WriteLine("hello");


        //}

        //public int cal(int x, int y,int z)
        //{
          //  int c = x + y+z; return c;


       // }
   // }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            abc stud = new abc();

            int c =stud.cal(1, 2,4);
            int d=stud.cal(1, 2);
            Console.WriteLine("add is " + c);
            Console.WriteLine("add is " + d);

            Console.ReadLine();



        }
    }
}
