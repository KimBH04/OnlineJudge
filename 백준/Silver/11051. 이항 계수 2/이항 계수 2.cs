using System;
using System.Numerics;

namespace _11051
{
    class Program
    {
        const int r = 10_007;
        static BigInteger[] m = new BigInteger[1001];

        static void Main(string[] args)
        {
            m[0] = 1;

            var input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), k = int.Parse(input[1]);

            for (int i = 1; i <= n; i++)
                if (m[i] == 0)
                    m[i] = i * m[i - 1];

            for (int i = 1; i <= k; i++)
                if (m[i] == 0)
                    m[i] = i * m[i - 1];

            for (int i = 1; i <= n - k; i++)
                if (m[i] == 0)
                    m[i] = i * m[i - 1];

            Console.WriteLine(m[n] / (m[k] * m[n - k]) % r);
        }
    }
}