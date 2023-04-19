using System;


namespace assig_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter name");
            string name;
            name = Convert.ToString(Console.ReadLine());

            string result = calculate(name); 
            Console.WriteLine("length is" + result);
        }

        static string calculate(string name2)
        {
            int counter;
            for(counter = 0; counter < name2.Length; counter++)
            {
               
                
                    Console.WriteLine(name2.Length);
                Console.ReadLine() ;
                

            }
            return name2;
                
        }
    }
}
