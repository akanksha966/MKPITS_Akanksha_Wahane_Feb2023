using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_1_example
{
    class Employee
    {
        private string _name;
        public string name //property
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                {

                    Console.WriteLine("name is required");
                }
                else
                {
                    this._name = value;
                }
            }

            get
            {
                
                


             return this._name;
                
            }
        }
    








        
        internal class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.name = "ashu";
                Console.WriteLine("name is " + emp.name);
                Console.ReadLine();
            }
        }
    }
}
