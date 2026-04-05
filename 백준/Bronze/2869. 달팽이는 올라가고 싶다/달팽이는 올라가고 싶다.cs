using System;

namespace Prob2869
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] b 
                = Array.ConvertAll(
                    Console.ReadLine().Split(), 
                    (a) => double.Parse(a));
            Console.WriteLine(
                Math.Ceiling((b[2] - b[1]) / (b[0] - b[1])));
        }
    }
}
