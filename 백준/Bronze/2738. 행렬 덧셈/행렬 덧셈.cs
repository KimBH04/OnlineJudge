using System;

namespace Prob2738
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine().Split();

            var A = int.Parse(times[0]);
            var B = int.Parse(times[1]);

            var hangnyeol = new int[A, B];

            for (int i = 0; i < A; i++)
            {
                var temp = Console.ReadLine().Split();

                for (int j = 0; j < B; j++)
                {
                    hangnyeol[i, j] = int.Parse(temp[j]);
                }
            }

            for (int i = 0; i < A; i++)
            {
                var temp = Console.ReadLine().Split();

                for (int j = 0; j < B; j++)
                {
                    Console.Write(hangnyeol[i, j] + int.Parse(temp[j]) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
