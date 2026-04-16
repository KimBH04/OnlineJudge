using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] b = new string[a];
            char[] c;
            int[] e = new int[a];

            for (int i = 0; i < a; i++)
            {
                int k = 1;
                int d = 0;

                b[i] = Console.ReadLine();
                c = b[i].ToString().ToCharArray();

                for(int j = 0; j < c.Length; j++)
                {
                    //Console.WriteLine(j);

                    if (c[j] == 'O')
                    {
                        d += k;
                        k++;
                    }
                    else
                        k = 1;
                }

                e[i] = d;
            }

            for (int i = 0; i < a; i++)
                Console.WriteLine(e[i]);
        }
    }
}

