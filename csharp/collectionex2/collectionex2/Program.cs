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

            ////////sorting code////////
             list.Sort();
            Console.WriteLine("array list collection using sorting");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            ////////Insert code////////


            list.Insert(2, "kalpana");
            Console.WriteLine("===========");

            Console.WriteLine("insert record");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            ////////Remove code////////

            list.Remove("kalpana");
            Console.WriteLine("**********");

            Console.WriteLine("insert record");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            ////////particular single variable code////////
            list.RemoveAt(0);
            Console.WriteLine("**********");

            Console.WriteLine("particular record deleted");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
