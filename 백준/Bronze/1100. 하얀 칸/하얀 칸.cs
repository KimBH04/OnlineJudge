using System;

namespace Prob1100
{
    class Program
    {
        static void Main(string[] args)
        {
            int chessmansOnWhie = 0;
            int[,] chessborad = new int[8, 8]
            {
                {0, 1, 0, 1, 0, 1, 0, 1 },
                {1, 0, 1, 0, 1, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 0, 1 },
                {1, 0, 1, 0, 1, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 0, 1 },
                {1, 0, 1, 0, 1, 0, 1, 0 },
                {0, 1, 0, 1, 0, 1, 0, 1 },
                {1, 0, 1, 0, 1, 0, 1, 0 },
            };
            for (int i = 0; i < 8; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < 8; j++)
                    if (chessborad[i, j] == 0 && input[j] == 'F')
                        chessmansOnWhie++;
            }
            Console.WriteLine(chessmansOnWhie);
        }
    }
}
