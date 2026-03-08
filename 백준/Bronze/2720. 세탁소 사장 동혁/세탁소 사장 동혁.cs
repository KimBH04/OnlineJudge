using System;

namespace Prob2720
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];
            int[] c = new int[4];
            string[][] d = new string[a][];

            for(int i = 0; i < a; i++)
            {
                b[i] = int.Parse(Console.ReadLine());

                c[0] = b[i] / 25;
                c[1] = b[i] % 25 / 10;
                c[2] = b[i] % 25 % 10 / 5;
                c[3] = b[i] % 5;

                d[i] = new string[4] 
                { 
                    c[0].ToString(), 
                    c[1].ToString(),
                    c[2].ToString(), 
                    c[3].ToString() 
                };
            }

            for (int i = 0; i < a; i++)
                Console.WriteLine("{0} {1} {2} {3}", 
                    d[i][0], 
                    d[i][1], 
                    d[i][2], 
                    d[i][3]);
            
        }
    }
}
