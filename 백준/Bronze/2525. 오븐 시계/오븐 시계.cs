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

            A = Console.ReadLine();
            int rT = int.Parse(A);

            int r = H * 60 + M + rT;

            if (r > 1439)
            {
                r = r - 1440;
            }

            Console.WriteLine("{0} {1}", (r - (r % 60)) / 60, r % 60);
        }
    }
}