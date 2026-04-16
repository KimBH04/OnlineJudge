using System;

namespace _26645
{
    class Program
    {
        static int idx;
        static int[] memo = new int[4];
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0, c = 8, m = 209; i < 4; i++, c /= 2, m += 10) Max(n, m, c);

            var max = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                if (max <= memo[i])
                {
                    max = memo[i];
                    idx = i + 1;
                }
            }

            Console.WriteLine(idx);
        }

        static void Max(int level, int maxLevel, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (level > maxLevel) break;
                level++;
            }

            memo[idx++] = level;
        }
    }
}
