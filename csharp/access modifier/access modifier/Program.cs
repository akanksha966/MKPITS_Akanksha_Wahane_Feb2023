using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifier
{
    class person
    {
        int id;
        void getdata()
        {
            Console.WriteLine("id is " + id);
            

        }
        public void getdata2()
        {
            Console.WriteLine("my name is akanksha");

        }



        internal class Program
        {
            static void Main(string[] args)
            {
                person n = new person();
                n.id = 1;
                n.getdata();
                n.getdata2();
                Console.ReadLine();
            }
        }
    }
    }

    
    
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            person n = new person();
//            n.id = 34444;
//            //n.getdata();
//}
