using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Encapusulation
{
    class person
    {
        string _name;
        public void setter(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("name is required");
            }
            else
            {
                _name = name;

            }
            
        }
        public void getter() //name kabhi bhi blank nhi rhta esliye hmne encapsulation ka use kr ke variable vo 
                             //private kiye aur method ko public kiye aur usme logical operation perfotm kiye
        {
            if (string.IsNullOrEmpty(_name))
            {

            }
            else
            {
                Console.WriteLine("your name is "+_name);
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person o = new person();
            o.setter("ashu");
            o.getter();
            Console.ReadLine();
        }
    }
}
