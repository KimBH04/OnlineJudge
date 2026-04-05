using System;
using System.Text;
using System.Numerics;

namespace _25618
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new System.Collections.Generic.List<BigInteger>();
            var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int b = input[0], c = input[1];
            a.Add(input[2]); a.Add(input[3]);

            for (int i = 2; i <= sbyte.MaxValue; i++)
            {
                a.Add(b * a[i - 1] + c * a[i - 2]);
            }

            Console.WriteLine(Sub(a[^1], a[^2]));
        }

        static string Sub(BigInteger a, BigInteger b)
        {
            var sb = "";

            sb += a / b;

            sb += ".";
            a = a % b * 10;
            for (int i = 0; i < 6; i++)
            {
                sb += a / b;

                a = a % b * 10;
            }

            return sb;
        }
    }
}
