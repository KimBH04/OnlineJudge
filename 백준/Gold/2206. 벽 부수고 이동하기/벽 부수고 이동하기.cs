string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

int[,] map = new int[n, m];
bool[,] breakVisited = new bool[n, m];
bool[,] unbreakVisited = new bool[n, m];
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine()!;
    for (int j = 0; j < m; j++)
    {
        map[i, j] = input[j] - '0';
        breakVisited[i, j] = unbreakVisited[i, j] = false;
    }
}

Console.WriteLine(BreathFirstSearch(map, breakVisited, unbreakVisited, n - 1, m - 1));

static int BreathFirstSearch(int[,] map, bool[,] breakVisited, bool[,] unbreakVisited, int n, int m)
{
    Queue<(int, int, bool)> queue = new();
    breakVisited[0, 0] = unbreakVisited[0, 0] = true;
    queue.Enqueue((0, 0, true));

    int[,] dir = { { 0, 1 }, { 0, -1 }, { -1, 0 }, { 1, 0 } };

    int cnt = 1;
    while (queue.Count > 0)
    {
        int qCnt = queue.Count;
        while (qCnt-- > 0)
        {
            var (r, c, b) = queue.Dequeue();
            if (r == n && c == m)
            {
                return cnt;
            }

            for (int i = 0; i < 4; i++)
            {
                int tr = r + dir[i, 0], tc = c + dir[i, 1];
                if (0 <= tr && tr <= n && 0 <= tc && tc <= m)
                {
                    if (b)
                    {
                        if (map[tr, tc] == 0 && !unbreakVisited[tr, tc])
                        {
                            unbreakVisited[tr, tc] = true;
                            queue.Enqueue((tr, tc, b));
                        }

                        if (map[tr, tc] == 1 && !breakVisited[tr, tc])
                        {
                            breakVisited[tr, tc] = true;
                            queue.Enqueue((tr, tc, false));
                        }
                    }
                    else
                    {
                        if (map[tr, tc] == 0 && !breakVisited[tr, tc])
                        {
                            breakVisited[tr, tc] = true;
                            queue.Enqueue((tr, tc, b));
                        }
                    }
                }
            }
        }
        cnt++;
    }

    return -1;
}
