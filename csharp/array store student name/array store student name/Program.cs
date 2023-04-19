using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_store_student_name
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] name = new string[5];
            for(int i=0; i<name.Length; i++)
            {
                Console.WriteLine("enter student name");
                name[i]=Convert.ToString(Console.ReadLine());


                

            }

            //display value

            for (int i = 0; i < name.Length; i++)
            {

                Console.WriteLine(name[i]);

               

            }
            Console.ReadLine();






        }
    }
    }

