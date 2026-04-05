using System;

namespace Star
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}