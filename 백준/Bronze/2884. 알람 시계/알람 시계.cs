using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string[] B = A.Split();

            int H = int.Parse(B[0]);
            int M = int.Parse(B[1]);

            int r = H * 60 + M - 45;

            if (r < 0)
            {
                r = 1440 + r;
            }

            Console.WriteLine("{0} {1}", (r - (r % 60)) / 60, r % 60);
        }
    }
}