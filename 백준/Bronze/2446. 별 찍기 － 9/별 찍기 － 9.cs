using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = a - i; j < a; j++)
                    Console.Write(' ');

                for (int k = 0; k < a * 2 - i * 2 - 1; k++)
                    Console.Write('*');

                Console.WriteLine();
            }

            for (int i = a - 2; i > -1; i--)
            {
                for (int j = i; j > 0; j--)
                    Console.Write(' ');

                for (int k = a * 2 - i * 2 - 1; k > 0; k--)
                    Console.Write('*');

                Console.WriteLine();
            }

        }
    }
}