using System;

namespace Prob
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[3];

            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                a1[i] = input;
            }

            int a = a1[0] * a1[1] * a1[2];

            char[] b = a.ToString().ToCharArray();

            for (int i = 0; i < 10; i++)
            {
                int count = 0;

                for (int j = 0; j < b.Length; j++)
                    if (b[j].ToString() == i.ToString())
                        count++;

                Console.WriteLine(count);
            }
        }
    }
}

