using System;

namespace Prob1975
{
    class Program
    {
        static void Main(string[] args)
        {
            using var sr = new System.IO.StreamReader(Console.OpenStandardInput());
            using var sw = new System.IO.StreamWriter(Console.OpenStandardOutput());

            var sb = new System.Text.StringBuilder();

            var times = int.Parse(sr.ReadLine());
            for (int i = 0; i < times; i++)
            {
                int zero = 0;
                var num = int.Parse(sr.ReadLine());
                for (int j = 2; j <= num; j++)
                {
                    int temp = num;
                    while (true)
                    {
                        if (temp % j == 0)
                        {
                            zero++;
                            temp /= j;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                sb.AppendLine(zero.ToString());
            }
            sw.WriteLine(sb);
        }
    }
}
