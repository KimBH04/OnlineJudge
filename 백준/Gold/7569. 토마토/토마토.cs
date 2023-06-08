using System;

namespace _7569
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new System.Collections.Generic.Queue<int[]>();
            var I = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = I[0], n = I[1], h = I[2];
            var t = new int[m, n, h];

            for (int k = 0; k < h; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    var strInput = Console.ReadLine().Split();
                    for (int j = 0; j < m; j++)
                    {
                        t[j, i, k] = int.Parse(strInput[j]);
                        if (t[j, i, k] == 1) q.Enqueue(new int[3] { j, i, k });
                    }
                }
            }

            while (q.Count > 0)
            {
                var C = q.Dequeue();

                int x = C[0], y = C[1], z = C[2];

                if (x + 1 < m)
                {
                    if (t[x + 1, y, z] == 0)
                    {
                        t[x + 1, y, z] = 1 + t[x, y, z];
                        var c = new int[3] { x + 1, y, z };
                        q.Enqueue(c);
                    }
                }

                if (x - 1 >= 0)
                {
                    if (t[x - 1, y, z] == 0)
                    {
                        t[x - 1, y, z] = 1 + t[x, y, z];
                        var c = new int[3] { x - 1, y, z };
                        q.Enqueue(c);
                    }
                }

                if (y + 1 < n)
                {
                    if (t[x, y + 1, z] == 0)
                    {
                        t[x, y + 1, z] = 1 + t[x, y, z];
                        var c = new int[3] { x, y + 1, z };
                        q.Enqueue(c);
                    }
                }

                if (y - 1 >= 0)
                {
                    if (t[x, y - 1, z] == 0)
                    {
                        t[x, y - 1, z] = 1 + t[x, y, z];
                        var c = new int[3] { x, y - 1, z };
                        q.Enqueue(c);
                    }
                }

                if (z + 1 < h)
                {
                    if (t[x, y, z + 1] == 0)
                    {
                        t[x, y, z + 1] = 1 + t[x, y, z];
                        var c = new int[3] { x, y, z + 1 };
                        q.Enqueue(c);
                    }
                }

                if (z - 1 >= 0)
                {
                    if (t[x, y, z - 1] == 0)
                    {
                        t[x, y, z - 1] = 1 + t[x, y, z];
                        var c = new int[3] { x, y, z - 1 };
                        q.Enqueue(c);
                    }
                }
            }

            var r = int.MinValue;

            foreach (var e in t)
            {
                if (e == 0)
                {
                    Console.WriteLine(-1);
                    return;
                }
                
                r = Math.Max(r, e - 1);
            }

            Console.WriteLine(r);
        }
    }
}