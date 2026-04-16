using System;

namespace _11653
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new System.Text.StringBuilder();

            var n = int.Parse(Console.ReadLine());

            for (int i = 2; n != 1; i++)
            {
                while (n % i == 0)
                {
                    sb.AppendLine(i.ToString());
                    n /= i;
                }
            }

            Console.Write(sb);
        }
    }
}
