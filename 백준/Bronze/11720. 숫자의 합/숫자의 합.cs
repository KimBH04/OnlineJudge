using System;

namespace Prob11720
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int times = int.Parse(Console.ReadLine());
            char[] nums = Console.ReadLine().ToCharArray();

            for (int i = 0; i < times; i++)
                sum += (int)Char.GetNumericValue(nums[i]);

            Console.WriteLine(sum);
        }
    }
}
