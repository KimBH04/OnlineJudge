using System;

namespace BookPage
{
    class Program
    {
        static int[] nums = new int[10];
        static int pow = 1;

        static void Main(string[] args)
        {
            var start = 1;
            var n = int.Parse(Console.ReadLine());

            while (true)
            {
                while (start % 10 != 0 && start <= n)
                    Cal(start++);

                if (start > n) break;

                while (n % 10 != 9)
                    Cal(n--);

                start /= 10;
                n /= 10;

                for (int i = 0; i < 10; i++)
                {
                    nums[i] += n * pow;
                }
                pow *= 10;
            }

            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
        }

        static void Cal(int n)
        {
            while (n > 0)
            {
                nums[n % 10] += pow;
                n /= 10;
            }
        }
    }
}
