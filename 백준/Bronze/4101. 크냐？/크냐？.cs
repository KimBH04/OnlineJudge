using System;
using System.Collections.Generic;

namespace Prob4101
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> YN = new List<string>();
            while (true)
            {
                int[] nums = 
                    Array.ConvertAll(
                        Console.ReadLine().Split(), (a) => int.Parse(a));
                if (nums[0] == 0 && nums[1] == 0)
                    break;
                if (nums[0] > nums[1])
                    YN.Add("Yes");
                else
                    YN.Add("No");
            }
            foreach (string a in YN)
                Console.WriteLine(a);
        }
    }
}
