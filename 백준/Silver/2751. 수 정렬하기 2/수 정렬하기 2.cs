using System;
using System.Text;

namespace Prob2750
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder c = new StringBuilder();
            int times = int.Parse(Console.ReadLine());
            int[] nums = new int[times];

            for (int i = 0; i < times; i++)
                nums[i] = int.Parse(Console.ReadLine());

            Array.Sort(nums);

            foreach(int a in nums)
                c.AppendLine(a.ToString());

            Console.WriteLine(c);
        }
    }
}
