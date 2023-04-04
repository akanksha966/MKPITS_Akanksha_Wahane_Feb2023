using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_product
{
    class produnt
    {
        public string productname;

        public string description;
        public int productid;
        public int generation;

        public void getdata()
        {
             productname ="ashu";
            description = " it is good model";
            productid = 2344;
            generation = 11;

        }

        public void display()
        {
            Console.WriteLine("enter productname " + productname);
            Console.WriteLine("enter deccription " +description);
            Console.WriteLine("enter productid " + productid);
            Console.WriteLine("enter generation " + generation);
            Console.ReadLine();




        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            produnt stud=new produnt();
            stud.getdata();
            stud.display();
        }
    }
}
