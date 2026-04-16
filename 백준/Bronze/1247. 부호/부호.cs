using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace prob1247
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                BigInteger Sum = 0;
                List<long> ls = new List<long>();
                int times = int.Parse(Console.ReadLine());
                for (int j = 0; j < times; j++)
                    ls.Add(long.Parse(Console.ReadLine()));
                foreach (long a in ls)
                    Sum += a;
                if (Sum < 0)
                    sb.AppendLine("-");
                else if (Sum > 0)
                    sb.AppendLine("+");
                else
                    sb.AppendLine("0");
            }
            Console.WriteLine(sb);
        }
    }
}
