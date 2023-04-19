using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_customer
{
    class customer
    {
        public int id;
        public string name;
        public string address;
        public string city;
        public string state;
        public int pincode;
        public string country;
        public int phone;

        public void getdata(int n,string c)
        {
            id = n;
            name = c;
            address = "gaytri mandir";
            city = "nagpur";
            state = "maharashtra";
            pincode = 441915;
            country = "India";
            phone = 1234576598;
                
        }

        public void display()
        {
            Console.WriteLine("id is " + id);
            Console.WriteLine("name is " + name);
            Console.WriteLine("address is  " + address);
            Console.WriteLine("city " + city);
            Console.WriteLine("state of  " + state);
            Console.ReadLine();



        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            customer stud= new customer();
            Console.WriteLine("enter id");
            int id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            string name=Console.ReadLine();

            stud. getdata(id,name);
            stud.display();
        }
    }
}
