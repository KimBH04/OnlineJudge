using System;

namespace _2178
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int n = int.Parse(input[0]), m = int.Parse(input[1]);
            var miro = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                var chrInput = Console.ReadLine().ToCharArray();
                for (int j = 0; j < m; j++)
                {
                    miro[i, j] = chrInput[j].ToString();
                }
            }

            var Q = new System.Collections.Generic.Queue<int[]>();
            Q.Enqueue(new int[2] { 0, 0 });

            while (Q.Count > 0)
            {
                var c = Q.Dequeue();

                if (c[0] == n - 1 && c[1] == m - 1)
                    break;

                if (c[0] + 1 < n)
                    if (miro[c[0] + 1, c[1]] == "1")
                    {
                        miro[c[0] + 1, c[1]] += miro[c[0], c[1]];
                        var coor = new int[2] { c[0] + 1, c[1] };
                        Q.Enqueue(coor);
                    }

                if (c[0] - 1 >= 0)
                    if (miro[c[0] - 1, c[1]] == "1")
                    {
                        miro[c[0] - 1, c[1]] += miro[c[0], c[1]];
                        var coor = new int[2] { c[0] - 1, c[1] };
                        Q.Enqueue(coor);
                    }

                if (c[1] + 1 < m)
                    if (miro[c[0], c[1] + 1] == "1")
                    {
                        miro[c[0], c[1] + 1] += miro[c[0], c[1]];
                        var coor = new int[2] { c[0], c[1] + 1 };
                        Q.Enqueue(coor);
                    }

                if (c[1] - 1 >= 0)
                    if (miro[c[0], c[1] - 1] == "1")
                    {
                        miro[c[0], c[1] - 1] += miro[c[0], c[1]];
                        var coor = new int[2] { c[0], c[1] - 1 };
                        Q.Enqueue(coor);
                    }

                miro[c[0], c[1]] = "0";
            }

            Console.WriteLine(miro[n - 1, m - 1].Length);
        }
    }
}
