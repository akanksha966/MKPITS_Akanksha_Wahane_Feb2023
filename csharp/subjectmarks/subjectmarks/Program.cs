using System;

namespace subjectmarks
{
     class Program
    {
        static void Main()
        {

            int s1,s2,s3,total;
            float per;
            string grade = "";
            Console.WriteLine("Enter subject1 marks");

            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter subject 2 marks ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter subject 3 marks ");
            s3 = Convert.ToInt32(Console.ReadLine());
            total = s1 + s2 + s3;
            
            Console.WriteLine("total = " + total);
            per = (total / 300.0f) * 100.0f;

            Console.WriteLine("per = " + per);
           
            if (per >= 75)
            {
                grade = "distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "first";
            }
            else
            {
                grade = "fail";

            }
            Console.WriteLine("Grade = " + grade);
            Console.ReadLine();


        }
    }
}
