using System;

namespace Prob1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), f = int.Parse(Console.ReadLine());
            n -= n % 100;
            while (n % f != 0)
                n++;
            char[] output = n.ToString().ToCharArray();
            Console.WriteLine("{0}{1}", output[^2], output[^1]);
        }
    }
}
