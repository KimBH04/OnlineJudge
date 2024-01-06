using System;
using System.Collections.Generic;

namespace _15591
{
    class Program
    {
        static bool[] V = new bool[5001];
        static int[,] usado = new int[5001, 5001];
        static List<int>[] edge = new List<int>[5001];

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var N = int.Parse(input[0]);
            var Q = int.Parse(input[1]);

            for (int i = 0; i <= N; i++)
            {
                edge[i] = new List<int>();
            }

            for (int i = 0; i < N - 1; i++)
            {
                input = Console.ReadLine().Split();
                var p = int.Parse(input[0]);
                var q = int.Parse(input[1]);
                var r = int.Parse(input[2]);

                edge[p].Add(q);
                edge[q].Add(p);

                usado[p, q] = usado[q, p] = r;
            }

            for (int i = 0; i < Q; i++)
            {
                V = new bool[5001];

                input = Console.ReadLine().Split();
                var k = int.Parse(input[0]);
                var v = int.Parse(input[1]);

                V[v] = true;

                BFS(k, v);
            }
        }

        static void BFS(int k, int v)
        {
            var u = 0;
            var Q = new Queue<int>();
            Q.Enqueue(v);

            while (Q.Count > 0)
            {
                var q = Q.Dequeue();

                foreach (var item in edge[q])
                {
                    if (!V[item] && usado[q, item] >= k)
                    {
                        u++;
                        V[item] = true;
                        Q.Enqueue(item);
                    }
                }
            }

            Console.WriteLine(u);
        }
    }
}
