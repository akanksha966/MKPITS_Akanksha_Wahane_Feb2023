using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fe_class
{
    public class person
    {
        public string name;
        public void names()
        {
          

            Console.WriteLine("name is "+name);
            

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            person person = new person();

            person.name = "akanska";
            person.names();
            Console.ReadLine();
        }
    }
}
