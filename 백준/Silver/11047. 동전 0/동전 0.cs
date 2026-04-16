using System;

namespace _11047
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            var input = Console.ReadLine().Split();
            var n = int.Parse(input[0]);
            var k = int.Parse(input[1]);

            var coins = new int[n];

            for (int i = 0; i < n; i++)
            {
                coins[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                while (k >= coins[^i])
                {
                    k -= coins[^i];
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
