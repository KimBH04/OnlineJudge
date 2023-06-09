using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            string Num = Console.ReadLine();
            string[] A = Num.Split();

            int N = int.Parse(A[0]);
            int X = int.Parse(A[1]);

            //Console.WriteLine(N);

            Num = Console.ReadLine();
            A = Num.Split();

            //Console.WriteLine(A.Length);

            string[] relativelySmall = new string[N];

            //Console.WriteLine(relativelySmall.Length);

            if (N == A.Length)

            for(int i = 0; i < N; i++)
            {
                if (int.Parse(A[i]) < X)
                {
                    relativelySmall[i] = A[i];

                    Console.Write(relativelySmall[i] + ' ');
                }
            }
        }
    }
}
