using System;
using System.Numerics;
using System.Text;

namespace Prob15792
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            BigInteger[] input = Array.ConvertAll(Console.ReadLine().Split(), (a) => BigInteger.Parse(a));
            sb.Append(input[0] / input[1]);
            if (input[0] % input[1] == 0)
                goto here;
            sb.Append(".");
            input[0] = input[0] % input[1] * 10;
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(input[0] / input[1]);
                if (input[0] % input[1] == 0)
                    goto here;
                input[0] = input[0] % input[1] * 10;
            }
        here:
            Console.WriteLine(sb);
        }
    }
}
