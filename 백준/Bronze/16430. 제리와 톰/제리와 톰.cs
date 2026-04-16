using System;

namespace Prob16430
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]), b = int.Parse(input[1]);
            Console.WriteLine("{0} {1}", b - a, b);
        }
    }
}
