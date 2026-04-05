using System;

namespace Prob1037
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), (a) => int.Parse(a));
            Array.Sort(input);
            Console.WriteLine(input[0] * input[^1]);
        }
    }
}
