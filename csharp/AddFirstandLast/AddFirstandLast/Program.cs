using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFirstandLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LinkedList<int> list = new LinkedList<int>();  
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddFirst(4);
            list.AddFirst(5);
            LinkedListNode<int> node = list.Find(3);
            list.AddBefore(node,10);
            

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
