using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for(int i = a; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Console.Write('*');

                Console.WriteLine();
            }
        }
    }
}

