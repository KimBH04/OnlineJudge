using System;

namespace _27065
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var result = 0;
                var n = int.Parse(Console.ReadLine());
                var nr = Math.Sqrt(n);
                var r = true;

                for (int j = 1; j <= nr; j++)
                {
                    if (n % j == 0)
                    {
                        result += j;
                        r = r && Morugetta(j);

                        if (j != n / j && n / j != n)
                        {
                            result += n / j;
                            r = r && Morugetta(n / j);
                        }
                    }
                }

                if (r && result > n)
                    Console.WriteLine("Good Bye");
                else
                    Console.WriteLine("BOJ 2022");
            }
        }

        static bool Morugetta(int n)
        {
            var result = 0;
            var nr = Math.Sqrt(n);

            for (int i = 1; i <= nr; i++)
            {
                if (n % i == 0)
                {
                    result += i;
                    if (i != n / i)
                    {
                        result += n / i;
                    }
                }
            }

            return result <= n * 2;
        }
    }
}