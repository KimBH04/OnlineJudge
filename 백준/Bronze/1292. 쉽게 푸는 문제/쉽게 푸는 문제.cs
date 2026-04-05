using System;

namespace Prob1292
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0, sum = 0;
            string[] input = Console.ReadLine().Split();
            int start = int.Parse(input[0]), end = int.Parse(input[1]);
            int[] nums = new int[end];
            for (int i = 1; k < end; i++)
                for (int j = 0; j < i && k < end; j++, k++)
                    nums[k] = i;
            for (int i = start - 1; i < end; i++)
                sum += nums[i];
            Console.WriteLine(sum);
        }
    }
}
