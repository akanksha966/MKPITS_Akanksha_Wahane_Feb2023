using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectionex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("bshu");
            list.Add("ashu");

            list.Add("rkanksha");
            Console.WriteLine("array list collection without sorting");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            ////////sorting code////////
             list.Sort();
            Console.WriteLine("array list collection withut sorting");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
