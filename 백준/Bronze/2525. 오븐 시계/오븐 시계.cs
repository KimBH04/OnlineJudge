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

            M= H * 60 + M + rT;

            if (M > 1439)
            {
                M = M - 1440;
            }

            Console.WriteLine("{0} {1}", (M - (M % 60)) / 60, M % 60);
        }
    }
}