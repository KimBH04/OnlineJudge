using System;

namespace _3040
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int?[9];
            var hundred = (int?)0;

            for (int i = 0; i < 9; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                hundred += nums[i];
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    if (hundred - nums[i] - nums[j] == 100)
                    {
                        nums[i] = nums[j] = null;
                        foreach (var item in nums)
                        {
                            if (item != null)
                            {
                                Console.WriteLine(item);
                            }
                        }

                        return;
                    }
                }
            }
        }
    }
}
