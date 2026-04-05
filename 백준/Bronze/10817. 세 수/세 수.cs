using System;

namespace Prob10817
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), (e) => int.Parse(e));
            Array.Sort(nums);
            Console.Write(nums[1]);
        }
    }
}
