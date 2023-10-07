int n = int.Parse(Console.ReadLine()!);
int[,] m = new int[n, n];
for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        m[i, j] = int.Parse(s[j]);
    }
}

int[,] d = new int[4, 2] { { 0, 1 }, { 0, -1 }, { -1, 0 }, { 1, 0 } };
int t = 0;
for (int i = 0; ; i++)
{
    int r = 0;
    bool[,] v = new bool[n, n];
    Array.Clear(v, 0, n * n);

    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            if (m[j, k] > i && !v[j, k])
            {
                r++;

                Queue<(int, int)> q = new();
                q.Enqueue((j, k));
                v[j, k] = true;

                while (q.Count > 0)
                {
                    var (x, y) = q.Dequeue();
                    for (int l = 0; l < 4; l++)
                    {
                        if (0 <= x + d[l, 0] && x + d[l, 0] < n && 0 <= y + d[l, 1] && y + d[l, 1] < n)
                        {
                            if (m[x + d[l, 0], y + d[l, 1]] > i && !v[x + d[l, 0], y + d[l, 1]])
                            {
                                v[x + d[l, 0], y + d[l, 1]] = true;
                                q.Enqueue((x + d[l, 0], y + d[l, 1]));
                            }
                        }
                    }
                }
            }
        }
    }

    t = r > t ? r : t;

    if (r == 0)
        break;
}

Console.WriteLine(t);