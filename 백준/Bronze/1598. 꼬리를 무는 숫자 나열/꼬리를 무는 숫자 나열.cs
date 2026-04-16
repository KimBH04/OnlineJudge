using System;

namespace Prob1598
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]), b = int.Parse(input[1]);
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            int height = a % 4;
            if (height == 0)
                height = 4;
            int absolutePosition = height;
            for (int i = a; i <= b; i++)
            {
                height++;
                if (height > 2 && i % 4 == 1)
                {
                    height = 1;
                    width++;
                }
            }
            Console.WriteLine(Math.Abs(absolutePosition - height) + width);
        }
    }
}
