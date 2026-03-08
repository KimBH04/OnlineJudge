using System;

namespace Prob10178
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int[] getCandies = new int[times], dadsCandies = new int[times];

            for (int i = 0; i < times; i++)
            {
                string[] input = Console.ReadLine().Split();
                getCandies[i] = int.Parse(input[0]) / int.Parse(input[1]);
                dadsCandies[i] = int.Parse(input[0]) % int.Parse(input[1]);
            }

            for (int i = 0; i < times; i++)
                Console.WriteLine("You get {0} piece(s) and your dad gets {1} piece(s).",
                    getCandies[i], dadsCandies[i]);

        }
    }
}
