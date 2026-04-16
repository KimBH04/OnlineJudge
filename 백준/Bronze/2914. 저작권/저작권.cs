using System;

namespace Prob2914
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(
                Console.ReadLine().Split(), (e) => int.Parse(e)) ;

            Console.Write(nums[0] * (nums[1] - 1) + 1);
        }
    }
}
