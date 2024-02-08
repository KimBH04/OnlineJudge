using System;

namespace _1463
{
    class Program
    {
        static int[] m = new int[10_000_001];

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                m[i] = m[i - 1] + 1;

                if (i % 2 == 0)
                    if (m[i] > m[i / 2] + 1)
                        m[i] = m[i / 2] + 1;

                if (i % 3 == 0)
                    if (m[i] > m[i / 3] + 1)
                        m[i] = m[i / 3] + 1;
            }

            Console.WriteLine(m[n]);
        }
    }
}
