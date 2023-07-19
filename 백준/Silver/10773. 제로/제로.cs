using System;
using System.Linq;
using System.Collections.Generic;

namespace Prob10773
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                    nums.RemoveAt(nums.Count - 1);
                else
                    nums.Add(input);
            }
            if (nums.Count == 0)
                Console.Write(0);
            else
                Console.Write(nums.Sum());
        }
    }
}
