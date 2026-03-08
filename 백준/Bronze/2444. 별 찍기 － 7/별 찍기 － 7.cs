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

                for (int j = a - 1; j > i; j--)
                    Console.Write(' ');
                
                for (int k = 0; k < 2 * (i + 1) - 1; k++)
                    Console.Write('*');

                Console.WriteLine();
            }

            for (int i = 1; i < a; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(' ');

                for (int k = a - i + (a - i - 1); k > 0; k--)
                    Console.Write('*');

                Console.WriteLine();
            }
        }
    }
}

