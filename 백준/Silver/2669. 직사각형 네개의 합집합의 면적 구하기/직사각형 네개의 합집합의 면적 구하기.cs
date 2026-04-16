using System;

namespace Prob2669
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            bool[,] coor = new bool[100, 100];
            for (int k = 0; k < 4; k++)
            {
                int[] area = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int i = area[0]; i < area[2]; i++)
                    for (int j = area[1]; j < area[3]; j++)
                        coor[i, j] = true;
            }
            foreach (var item in coor)
                if (item == true)
                    total++;
            Console.WriteLine(total);
        }
    }
}
