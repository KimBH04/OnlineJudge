using System;
using System.Numerics;

namespace Prob1271
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Array.ConvertAll(Console.ReadLine().Split(), (a) => BigInteger.Parse(a));
            Console.WriteLine(input[0] / input[1]);
            Console.WriteLine(input[0] % input[1]);
        }
    }
}
