using System;

namespace Prob3046
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input
                = Array.ConvertAll
                (Console.ReadLine().Split(), (a) => int.Parse(a));
            Console.Write(input[1] * 2 - input[0]);
        }
    }
}
