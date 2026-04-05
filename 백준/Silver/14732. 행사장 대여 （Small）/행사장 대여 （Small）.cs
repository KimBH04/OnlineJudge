using System;

namespace Prob14732
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = 0;
            bool[,] coor = new bool[501, 501];
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int[] coorValue =
                    Array.ConvertAll(
                        Console.ReadLine().Split(), (a) => int.Parse(a));
                for (int j = coorValue[0]; j < coorValue[2]; j++)
                    for (int k = coorValue[1]; k < coorValue[3]; k++)
                        coor[j, k] = true;
            }
            for (int j = 0; j <= 500; j++)
                for (int k = 0; k <= 500; k++)
                    if (coor[j, k] == true)
                        area++;
            Console.WriteLine(area);
        }
    }
}
