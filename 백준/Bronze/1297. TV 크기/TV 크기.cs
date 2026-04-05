using System;

namespace Prob1297
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            double h = input[1], w = input[2], d = input[0];
            double a = d / Math.Sqrt(h * h + w * w);
            Console.WriteLine("{0:0} {1:0}", Math.Truncate(h * a), Math.Truncate(w * a));
        }
    }
}
