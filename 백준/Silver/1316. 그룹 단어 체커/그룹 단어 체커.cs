using System;
using System.Linq;
using System.Collections.Generic;

namespace Prob1316
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int nums = times;
             
            for (int i = 0; i < times; i++)
            {
                List<int> ls = new List<int>();

                var input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < input.Length; j++)
                {
                    try
                    {
                        if (input[j] != input[j + 1])
                        {
                            ls.Add(input[j]);
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        ls.Add(input[j]);
                    }
                }
                var bLsCount = ls.Count;
                ls = ls.Distinct().ToList();
                var aLsCount = ls.Count;

                if (bLsCount != aLsCount)
                {
                    nums--;
                }
            }
            Console.WriteLine(nums);
        }
    }
}
