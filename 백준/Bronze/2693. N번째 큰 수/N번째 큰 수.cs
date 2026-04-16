using System;

namespace Prob2693
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int[] _3thNum = new int[times];
            for (int i = 0; i < times; i++)
            {
                int[] nums = Array.ConvertAll(Console.ReadLine().Split(), (a) => int.Parse(a));
                Array.Sort(nums);
                Array.Reverse(nums);
                _3thNum[i] = nums[2];
            }
            foreach (int item in _3thNum)
                Console.WriteLine(item);
        }
    }
}
