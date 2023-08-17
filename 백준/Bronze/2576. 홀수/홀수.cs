using System;

namespace Prob2576
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7];
            int b = 0;
            int c = int.MaxValue;

            for (int i = 0; i < 7; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

                if (a[i] % 2 != 0)
                {
                    b += a[i];

                    if (c > a[i] && a[i] % 2 != 0)
                        c = a[i]; ;
                }
            }

            if (b == 0)
                Console.WriteLine(-1);
            else
            {
                Console.WriteLine(b);
                Console.Write(c);
            }
        }
    }
}
