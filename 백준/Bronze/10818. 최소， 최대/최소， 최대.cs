using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string nums = Console.ReadLine();
            string[] nums2 = nums.Split();

            int max = int.Parse(nums2[0]);
            int mini = int.Parse(nums2[0]);

            for(int i = 0; i < input; i++)
            {
                if (max < int.Parse(nums2[i]))
                    max = int.Parse(nums2[i]);

                if (mini > int.Parse(nums2[i]))
                    mini = int.Parse(nums2[i]);
            }

            Console.WriteLine("{0} {1}", mini, max);
        }
    }
}

