using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();

            int a = int.Parse(A);

            A = Console.ReadLine();

            int b = int.Parse(A);

            if (a > 0 && b > 0)
            {
                Console.WriteLine("1");
            }
            if (a < 0 && b > 0)
            {
                Console.WriteLine("2");
            }
            if (a < 0 && b < 0)
            {
                Console.WriteLine("3");
            }
            if (a > 0 && b < 0)
            {
                Console.WriteLine("4");
            }
        }
    }
}