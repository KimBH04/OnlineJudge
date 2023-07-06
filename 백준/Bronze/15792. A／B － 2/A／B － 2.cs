using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] input = Array.ConvertAll(Console.ReadLine().Split(), (a) => decimal.Parse(a));
            Console.WriteLine(input[0] / input[1]);
        }
    }
}
