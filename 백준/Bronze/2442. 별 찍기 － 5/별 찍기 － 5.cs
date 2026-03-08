using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());

            for (int i = 0; i < A; i++)
            {

                for (int y = A - 1; y > i; y--)
                {
                    Console.Write(' ');
                }

                for (int x = 0; x < 2 * (i + 1) - 1; x++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}
