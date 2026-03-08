using System;

namespace Prob2592
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int sum = 0;
            int[] modes = new int[100];
            int mode = 0;
            int max = 0;

            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                sum += nums[i];
                modes[nums[i] / 10 - 1]++;
            }

            sum /= 10;

            for (int i = 0; i < 100; i++)
                if (modes[i] > max)
                {
                    max = modes[i];
                    mode = (i + 1) * 10;
                }

            Console.WriteLine("{0}\n{1}", sum, mode);
        }
    }
}
