using System;

namespace _4948
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1.1f + 1.2f != 2.3f)
            {
                var n = int.Parse(Console.ReadLine());
                if (n * 2 == n) return;

                var result = n * 2 - n;

                for (int i = n + 1; i <= n * 2; i++)
                {
                    if (i == 2) continue;

                    for (int j = 2; j <= Math.Sqrt(i); j++)
                        if (i % j == 0)
                        {
                            result--;
                            break;
                        }
                }

                Console.WriteLine(result);
            }
        }
    }
}
