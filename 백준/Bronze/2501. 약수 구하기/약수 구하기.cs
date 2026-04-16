using System;

namespace Prob2501
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]), K = int.Parse(input[1]);
            int count = 0;
            int[] nums = new int[K];
            for (int i = N; count < K; i--)
            {
                if (i == 0)
                    break;
                if (N % i == 0)
                {
                    nums[count] = N / i;
                    count++;
                }
            }
            Console.WriteLine(nums[K - 1]);
        }
    }
}
