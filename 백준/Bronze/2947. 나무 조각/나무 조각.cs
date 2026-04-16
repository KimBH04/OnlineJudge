using System;

namespace Prob2947
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(
                            Console.ReadLine().Split(), 
                            (e) => int.Parse(e));

            here:
            for (int i = 0; i < 4; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    int temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;

                    foreach (int a in nums)
                        Console.Write(a + " ");

                    Console.WriteLine();
                }
            }

            for (int i = 0; i < 4; i++)
                if (nums[i] > nums[i + 1])
                    goto here;
        }
    }
}
