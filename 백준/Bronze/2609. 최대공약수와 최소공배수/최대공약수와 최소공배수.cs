using System;

namespace Prob2609
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), (a) => int.Parse(a));
            int a = nums[0], b = nums[1];
            int temp = 0;
            while (true)
            {
                temp = nums[0] % nums[1];
                if (temp == 0)
                    break;
                nums[0] = nums[1];
                nums[1] = temp;
            }
            Console.WriteLine("{0}\n{1}", nums[1], a * b / nums[1]);
        }
    }
}
