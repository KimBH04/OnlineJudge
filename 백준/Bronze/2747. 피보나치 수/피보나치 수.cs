using System;

namespace Prob2747
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a + 1];
            b[0] = 0;
            b[1] = 1;

            for(int i = 2; i < a + 1; i++)
            {
                b[i] = b[i - 2] + b[i - 1];
            }

            Console.Write(b[a]);
        }
    }
}
