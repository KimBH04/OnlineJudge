using System;

namespace _14730
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            var n = int.Parse(Console.ReadLine());
            var nums = new int[n][];

            for (int i = 0; i < n; i++)
            {
                nums[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                nums[i][0] *= nums[i][1];
            }

            foreach (var item in nums)
            {
                result += item[0];
            }

            Console.WriteLine(result);
        }
    }
}
