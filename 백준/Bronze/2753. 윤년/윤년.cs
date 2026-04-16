using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string[] B = A.Split();

            double a = double.Parse(B[0]);

            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}