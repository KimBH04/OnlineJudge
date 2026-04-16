using System;

namespace Prob1085
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), (a) => int.Parse(a));
            int x = input[0], y = input[1], w = input[2], h = input[3];
            if (x > w - x)
                x = w - x;
            if (y > h - y)
                y = h - y;
            if (x > y)
                Console.WriteLine(y);
            else
                Console.WriteLine(x);
        }
    }
}
