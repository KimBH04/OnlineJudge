using System;

namespace Prob2475
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), (a) => int.Parse(a));
            nums[0] *= nums[0];
            nums[1] *= nums[1];
            nums[2] *= nums[2];
            nums[3] *= nums[3];
            nums[4] *= nums[4];
            foreach (int item in nums)
                sum += item;
            Console.WriteLine(sum % 10);
        }
    }
}
