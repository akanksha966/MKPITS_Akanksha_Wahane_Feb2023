using System;
namespace threeno
{
    class Program
    {
        static void Main()

        {
            int rollno, age;
            double mobileno;
            string name, course;

            Console.WriteLine("please enter your roll no");
            rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter your age secretly");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter your mobile no");
            mobileno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter your name dear");
            name = Console.ReadLine();


            Console.WriteLine("please enter your courses");
            course = Console.ReadLine();

            Console.WriteLine("hello miss " + name);

            Console.WriteLine(" Course is " + course);

            Console.WriteLine("roll no is " + rollno);

            Console.WriteLine("mob no is " + mobileno);

            Console.WriteLine("age is " + age);



            Console.ReadKey();
        }
    }

}
    

