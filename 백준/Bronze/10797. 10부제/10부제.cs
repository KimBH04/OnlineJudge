using System;

namespace Prob10797
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] b = Console.ReadLine().Split();
            int nums = 0;

            for (int i = 0; i < 5; i++)
                if (int.Parse(b[i]) == a)
                    nums += 1;

            Console.WriteLine(nums);
        }
    }
}
