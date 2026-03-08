using System;

namespace Prob10998
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string[] B = A.Split();

            int a = int.Parse(B[0]);
            int b = int.Parse(B[1]);

            Console.WriteLine(a * b);
        }
    }
}
