using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collectionex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ilist = new List<string>();
            ilist.Add("E");
            ilist.Add("B");
            ilist.Add("C");
            ilist.Add("D");
            ilist.Add("E");
            Console.WriteLine(ilist.Contains("Z"));
            Console.WriteLine(ilist[1]);
            Console.WriteLine(ilist[3]);
           //////////////////////////////////////////////////
            Console.WriteLine("===========");
            ilist.Sort();
            ilist.Insert(5, "Z");
            ilist.RemoveAt(5);
            foreach (string item in ilist)
            {
                Console.WriteLine(item);
            }
            /////////////////////////////////////
            ilist.Insert(5, "Z");
          
           


        }
        
    }
}
