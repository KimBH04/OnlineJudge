using System;

namespace Prob2839
{
    class Program
    {
        static void Main(string[] args)
        {
            int sugars = int.Parse(Console.ReadLine());
            int a = Sugar(sugars);
            Console.WriteLine(a);
        }
        static int Sugar(int N)
        {
            int temp = N;
            for (int i = 0; ; i++)
            {
                if (N - 3 * i < 0)
                {
                    return -1;
                }
                else if ((N - 3 * i) % 5 == 0)
                {
                    return i + (N - 3 * i) / 5;
                }
                else
                {
                    N = temp;
                }
            }
        }
    }
}
