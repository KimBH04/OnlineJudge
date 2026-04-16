using System;

namespace Prob5565
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int [10];

            for(int i = 0; i < 10; i++)
            {
                int b = int.Parse(Console.ReadLine());
                a[i] = b;

                if(i > 0)
                {
                    a[0] -= a[i];
                }
            }

            Console.WriteLine(a[0]);
        }
    }
}
