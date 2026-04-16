using System;

namespace Prob1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] drainage = new int[10];
            int l = 0;
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), (a) => int.Parse(a));
            for (int i = 0; i < 3; i++)
                for (int j = i + 1; j < 4; j++)
                    for (int k = j + 1; k < 5; k++, l++)
                    {
                        int a = nums[i], b = nums[j], c = nums[k], temp = 0;
                        while (true)
                        {
                            temp = a % b;
                            if (temp == 0)
                                break;
                            a = b;
                            b = temp;
                        }
                        drainage[l] = nums[i] * nums[j] / b;
                        b = drainage[l];
                        while (true)
                        {
                            temp = b % c;
                            if (temp == 0)
                                break;
                            b = c;
                            c = temp;
                        }
                        drainage[l] *= nums[k] / c; 
                    }
            Array.Sort(drainage);
            Console.WriteLine(drainage[0]);
        }
    }
}
