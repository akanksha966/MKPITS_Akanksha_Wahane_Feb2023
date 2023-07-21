using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("ashu");
            list.Add("ashu");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



        }
    }
}
