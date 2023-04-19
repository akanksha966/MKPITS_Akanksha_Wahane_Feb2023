using System;


namespace pattern
{
    class Program
    {
        static void Main()
        {
            int row, col;
            for(row=3;row>0;row--)
            {
                for(col=1;col<=row;col++)
                {
                    Console.WriteLine(col + "\t");
                }
                
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
