using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            string Num = Console.ReadLine();
            int NoT = int.Parse(Num);

            int[] aW = new int[NoT];

            string[] Cf = new string[NoT];

            for (int i = 0; i < NoT; i++)
            {
                string b = Console.ReadLine();
                string[] c = b.Split();
                int A = int.Parse(c[0]);
                int B = int.Parse(c[1]);

                aW[i] = A + B;

                Cf[i] = c[0] + " + " + c[1];
            }

            for (int i = 0; i < NoT; i++)
            {
                Console.WriteLine("Case #{1}: {2} = {0}", aW[i], i + 1, Cf[i]);
            }
        }
    }
}
