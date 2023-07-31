using System;

namespace Prob2556
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < times; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}
