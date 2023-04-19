using System;


namespace switchprog1
{
     class Program
    {
        static void Main()
        {
            string empname, designation;
            int bonus = 0;
            Console.WriteLine("enter empname ");
            empname = Console.ReadLine();
            Console.WriteLine("enter designation ");
            designation = Console.ReadLine();
            switch (designation)

            {
                case "manager":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
                default:
                    Console.WriteLine("invalid designation");

                    break;

            }
            Console.WriteLine("empname = " +empname     +"bonus= " +bonus);
            Console.ReadLine();


        }
    }
}
