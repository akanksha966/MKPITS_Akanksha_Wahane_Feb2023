using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_acceess_modifier
{
    class animal
    {
        internal string name;
        internal void dog()
        {
            Console.WriteLine(" name is " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            animal dog = new animal();
            dog.name = "Dog";
            dog.dog();  
            Console.ReadLine(); 
        }
    }
}
