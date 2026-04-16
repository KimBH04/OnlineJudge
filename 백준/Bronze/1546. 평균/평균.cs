using System;
using System.Linq;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            float[] b = new float[a];

            string[] c = Console.ReadLine().Split();
            
            float d = 0f;

            float total = 0f;

            for (int i = 0; i < a; i++)
                b[i] = float.Parse(c[i]);

            for(int i = 0; i < a; i++)
            {
                if (d < b[i])
                    d = b[i];
            }
            //Console.WriteLine(d);

            for (int i = 0; i < a; i++)
            {
                total += b[i] / d * 100;
                //Console.WriteLine(b[i]);
                //Console.WriteLine(total);
            }
                

            Console.WriteLine(total / a);
        }
    }
}

