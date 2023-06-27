using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double[] b = new double[a];
            double[] d = new double[a];

            for(int i = 0; i < a; i++)
            {
                string[] c = Console.ReadLine().Split();
                double e = 100 / double.Parse(c[0]);
                //Console.WriteLine(e);

                for (int j = 1; j <= int.Parse(c[0]); j++)
                {
                    d[i] += double.Parse(c[j]);
                }
                d[i] = d[i] / double.Parse(c[0]);
                //Console.WriteLine(d[i]);

                for (int j = 1; j < c.Length; j++)
                    if (double.Parse(c[j]) > d[i])
                        b[i] += e;
            }           

            for(int i = 0; i < a; i++)
            {
                Console.WriteLine("{0:0.000}%", b[i]);
            }
        }
    }
}

