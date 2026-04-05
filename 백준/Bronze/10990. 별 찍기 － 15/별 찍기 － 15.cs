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
                for (int j = 1; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                if (i > 0)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}