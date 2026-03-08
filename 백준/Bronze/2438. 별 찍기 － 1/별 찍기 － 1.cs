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
                for (int x = -1; x < i; x++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}
