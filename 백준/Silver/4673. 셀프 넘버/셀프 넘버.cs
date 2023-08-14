using System;

namespace Prob4673
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] unSelfNums = new int[10000];

            for (int i = 1; i <= 10000; i++)
            {
                n = i;
                
                int[] uSNfx = new int[4];
                uSNfx[0] = n % 10;
                uSNfx[1] = (n % 100 - uSNfx[1]) / 10;
                uSNfx[2] = (n % 1000 - uSNfx[1] - uSNfx[2]) / 100;
                uSNfx[3] = (n % 10000 - uSNfx[1] - uSNfx[2] - uSNfx[3]) / 1000;

                for (int j = 0; j < 4; j++)
                    n += uSNfx[j];
                

                if (n <= 10000)
                    unSelfNums[n - 1] = n;
            }
            for (int i = 0; i < 10000; i++)
                if (unSelfNums[i] == 0)
                    Console.WriteLine(i + 1);
        }
    }
}
