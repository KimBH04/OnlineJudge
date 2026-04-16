using System;
using System.IO;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoT = int.Parse(Console.ReadLine());

            int[] aW = new int[] { 0, 0 };

            for (int i = 0; i < NoT; i++)
            {
                string b = Console.ReadLine();
                string[] c = b.Split();
                int A = int.Parse(c[0]);
                int B = int.Parse(c[1]);

                if (A > B)
                {
                    aW[0] += 1;
                }
                if (A < B)
                {
                    aW[1] += 1;
                }
            }
            Console.Write(aW[0] + " " + aW[1]);
        }
    }
}
