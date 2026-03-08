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
                for (int j = a - i; j < a + 1; j++)
                    Console.Write('*');

                for (int k = a - i - 1; k > 0; k--)
                    Console.Write(' ');

                for (int k = a - i - 1; k > 0; k--)
                    Console.Write(' ');

                for (int j = a - i; j < a + 1; j++)
                    Console.Write('*');

                Console.WriteLine();
            }

            for (int i = a; i > 0; i--)
            {
                for (int j = i - 1; j > 0; j--)
                    Console.Write('*');

                for (int k = i - 1; k < a; k++)
                    Console.Write(' ');

                for (int k = i - 1; k < a; k++)
                    Console.Write(' ');

                for (int j = i - 1; j > 0; j--)
                    Console.Write('*');

                Console.WriteLine();
            }
        }
    }
}

