using System;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[5];

            for (int i = 0; i < 5; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nums);

            Console.WriteLine((nums[0] + nums[1] + nums[2] + nums[3] + nums[4]) / 5);
            Console.WriteLine(nums[2]);
        }
    }
}
