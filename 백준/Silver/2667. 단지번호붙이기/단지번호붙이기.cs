using System;

namespace _2667
{
    class Program
    {
        static char[,] m;
        static void Main(string[] args)
        {
            var ls = new System.Collections.Generic.List<int>();
            var n = int.Parse(Console.ReadLine());
            m = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < n; j++)
                {
                    m[i, j] = input[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (m[i, j] == '1') ls.Add(DFS(i, j));
                }
            }

            ls.Sort();
            Console.WriteLine(ls.Count);
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
        }

        static int DFS(int x, int y)
        {
            m[x, y] = '0';
            var r = 1;

            try { if (m[x + 1, y] == '1') r += DFS(x + 1, y); } catch { }
            try { if (m[x - 1, y] == '1') r += DFS(x - 1, y); } catch { }
            try { if (m[x, y + 1] == '1') r += DFS(x, y + 1); } catch { }
            try { if (m[x, y - 1] == '1') r += DFS(x, y - 1); } catch { }

            return r;
        }
    }
}
