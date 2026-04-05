using System;
using System.Collections.Generic;

namespace _2606
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Queue<int>();
            q.Enqueue(1);

            var com = int.Parse(Console.ReadLine());
            var num = int.Parse(Console.ReadLine());

            var e = new List<int>[com + 1];
            var v = new bool[com + 1];
            v[1] = true;

            for (int i = 0; i <= com; i++)
            {
                e[i] = new List<int>();
            }

            for (int i = 0; i < num; i++)
            {
                var l = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                e[l[0]].Add(l[1]);
                e[l[1]].Add(l[0]);

                e[l[0]].Sort();
                e[l[1]].Sort();
            }

            while (q.Count > 0)
            {
                var virus = q.Dequeue();

                foreach (var item in e[virus])
                {
                    if (!v[item])
                    {
                        v[item] = true;
                        q.Enqueue(item);
                    }
                }
            }

            var result = -1;

            foreach (var item in v) if (item) result++;

            Console.WriteLine(result);
        }
    }
}
