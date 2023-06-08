using System;

namespace _7576
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new System.Collections.Generic.Queue<int[]>();
            var I = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = I[0], n = I[1];

            var t = new int[m, n];

            for (int i = 0; i < n; i++)
            {
                I = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < m; j++)
                {
                    t[j, i] = I[j];
                    if (t[j, i] == 1)
                    {
                        q.Enqueue(new int[2] { j, i });
                    }
                }
            }

            while (q.Count > 0)
            {
                var C = q.Dequeue();
                int x = C[0], y = C[1];

                if (x + 1 < m)
                    if (t[x + 1, y] == 0)
                    {
                        t[x + 1, y] += t[x, y] + 1;
                        var c = new int[2] { x + 1, y };
                        q.Enqueue(c);
                    }
                
                if (x - 1 >= 0)
                    if (t[x - 1, y] == 0)
                    {
                        t[x - 1, y] += t[x, y] + 1;
                        var c = new int[2] { x - 1, y };
                        q.Enqueue(c);
                    }

                if (y + 1 < n)
                    if (t[x, y + 1] == 0)
                    {
                        t[x, y + 1] += t[x, y] + 1;
                        var c = new int[2] { x, y + 1 };
                        q.Enqueue(c);
                    }

                if (y - 1 >= 0)
                    if (t[x, y - 1] == 0)
                    {
                        t[x, y - 1] += t[x, y] + 1;
                        var c = new int[2] { x, y - 1 };
                        q.Enqueue(c);
                    }
            }

            var r = 0;
            
            foreach (var i in t)
            {
                if (i == 0)
                {
                    Console.WriteLine(-1);
                    return;
                }

                if (i != -1) r = Math.Max(r, i - 1);
            }

            Console.WriteLine(r);
        }
    }
}