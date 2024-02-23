using System;
using System.Text;

namespace Prob1929
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var input = Console.ReadLine().Split();

            var m = int.Parse(input[0]); var n = int.Parse(input[1]);

            for (int i = m; i <= n; i++)
            {
                if (i == 1) continue;
                if (i == 2)
                {
                    sb.AppendLine(i.ToString());
                    continue;
                }

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                        goto here;
                }

                sb.AppendLine(i.ToString());
            here:;
            }

            Console.Write(sb.ToString());
        }
    }
}
