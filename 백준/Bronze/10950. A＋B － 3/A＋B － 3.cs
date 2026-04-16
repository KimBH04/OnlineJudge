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

            for(int i = 0; i < NoT; i++)
            {
                string b = Console.ReadLine();
                string[] c = b.Split();
                int A = int.Parse(c[0]);
                int B = int.Parse(c[1]);

                aW[i] = A + B;
            }

            for(int i = 0; i < NoT; i++)
            {
                Console.WriteLine("{0}", aW[i]);
            }
        }
    }
}
