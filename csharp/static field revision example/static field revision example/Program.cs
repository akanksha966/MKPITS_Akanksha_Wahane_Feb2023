using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field_revision_example
{
    public class person
    {
        public int id;
        public string name;
        public static float salary=20000;
        public void getdata(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("id is " + id);
            Console.WriteLine("name is " + name);
            Console.WriteLine("salary is " + salary);


        }
        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
           
            
            p.getdata(4545,"ashu");
            p.display();
            Console.ReadLine();
        }
    }
}
