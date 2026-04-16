using System;
using System.Linq;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int input = int.Parse(Console.ReadLine());
                a[i] = input % 42;
            }

            int[] b = a.Distinct().ToArray();

            Console.Write(b.Length);
        }
    }
}

