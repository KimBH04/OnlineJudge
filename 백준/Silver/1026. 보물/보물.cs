using System;

namespace Prob1026
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int times = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < times; j++)
            { for (int i = 0; i < times - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                    if (b[i] < b[i + 1])
                    {
                        int temp = b[i];
                        b[i] = b[i + 1];
                        b[i + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < times; i++)
            {
                sum += a[i] * b[i];
            }
            Console.WriteLine(sum);
        }
    }
}
