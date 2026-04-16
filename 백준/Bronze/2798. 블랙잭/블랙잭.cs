using System;

namespace Prob2798
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = int.MinValue;
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[int.Parse(input[0])];
            int maximum = int.Parse(input[1]);
            input = Console.ReadLine().Split();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int sum = int.Parse(input[i]) + int.Parse(input[j]) + int.Parse(input[k]);
                        if (sum > totalSum && sum <= maximum)
                        {
                            totalSum = sum;
                        }
                    }
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
