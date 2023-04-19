using System;


namespace array_csharp
{
   class Program
    {
        static void Main()
        {

            float[] arr = new float[4];
            arr[0] = 4.1f;
            arr[1] = 4.5f;
            arr[2] = 4.4f;
            arr[3] = 4.9f;
            foreach(float val in arr)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
        }
    }
}
