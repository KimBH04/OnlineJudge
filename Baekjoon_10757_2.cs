using System;
using System.Numerics;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            BigInteger bi = BigInteger.Parse(input[0]), bi2 = BigInteger.Parse(input[1]);
            Console.WriteLine(bi + bi2);
        }
    }
}
