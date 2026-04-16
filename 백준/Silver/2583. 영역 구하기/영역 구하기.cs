using System;

namespace _2538
{
    class Program
    {
        static bool[,] p;
        static void Main(string[] args)
        {
            var ls = new System.Collections.Generic.List<int>();

            var mnt = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            p = new bool[mnt[1], mnt[0]];

            for (int t = 0; t < mnt[2]; t++)
            {
                var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                for (int i = input[0]; i < input[2]; i++)
                {
                    for (int j = input[1]; j < input[3]; j++)
                    {
                        p[i, j] = true;
                    }
                }
            }

            for (int i = 0; i < mnt[1]; i++)
            {
                for (int j = 0; j < mnt[0]; j++)
                {
                    if (!p[i, j])
                    {
                        ls.Add(DFS(i, j));
                    }
                }
            }

            ls.Sort();
            Console.WriteLine(ls.Count);
            foreach (var item in ls)
            {
                Console.Write(item + " ");
            }
        }

        static int DFS(int x, int y)
        {
            p[x, y] = true;
            var r = 1;

            try { if (!p[x + 1, y]) r += DFS(x + 1, y); } catch { }
            try { if (!p[x - 1, y]) r += DFS(x - 1, y); } catch { }
            try { if (!p[x, y + 1]) r += DFS(x, y + 1); } catch { }
            try { if (!p[x, y - 1]) r += DFS(x, y - 1); } catch { }

            return r;
        }
    }
}
