using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sqs = new int[9];

            for (int i = 0; i < 9; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sqs[i] = input;
            }

            int max = 0;
            int maxs = 0;

            for(int i = 0; i < 9; i++)
            {
                if (max < sqs[i])
                {
                    max = sqs[i];
                    maxs = i + 1;
                }
            }

            Console.WriteLine("{0}\n{1}", max, maxs);
        }
    }
}

