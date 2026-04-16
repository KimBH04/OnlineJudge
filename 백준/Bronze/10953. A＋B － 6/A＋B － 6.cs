using System;

namespace Prob10953
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int[] sums = new int[times];

            for (int i = 0; i < times; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                sums[i] = (int)Char.GetNumericValue(input[0])
                    + (int)Char.GetNumericValue(input[2]);
            }

            foreach (int a in sums)
                Console.WriteLine(a);
        }
    }
}
