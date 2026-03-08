using System;
using System.IO;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoT = int.Parse(Console.ReadLine());
            StringWriter sw = new StringWriter();

            int[] aW = new int[NoT];

            for (int i = 0; i < NoT; i++)
            {
                string b = Console.ReadLine();
                string[] c = b.Split();
                int A = int.Parse(c[0]);
                int B = int.Parse(c[1]);

                aW[i] = A + B;
                sw.WriteLine(aW[i]);
            }
            Console.Write(sw.ToString());
        }
    }
}
