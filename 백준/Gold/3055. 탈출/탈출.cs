string[] inputs = Console.ReadLine()!.Split();
int r = int.Parse(inputs[0]), c = int.Parse(inputs[1]);

bool[,] waterV = new bool[r, c], hedgehogV = new bool[r, c];
Queue<(int, int)> water = new(), hedgehog = new();

char[,] map = new char[r, c];
for (int i = 0; i < r; i++)
{
    string s = Console.ReadLine()!;
    for (int j = 0; j < c; j++)
    {
        map[i, j] = s[j];
        if (s[j] == '*')
        {
            waterV[i, j] = true;
            water.Enqueue((i, j));
        }
        else if (s[j] == 'S')
        {
            hedgehogV[i, j] = true;
            hedgehog.Enqueue((i, j));
        }
    }
}

(int, int)[] dir = { (0, 1), (1, 0), (-1, 0), (0, -1) };
int cnt = 0;
while (hedgehog.Count > 0)
{
    int wcnt = water.Count;
    while (wcnt-- > 0)
    {
        var (wr, wc) = water.Dequeue();
        foreach (var (row, col) in dir)
        {
            int tr = wr + row;
            int tc = wc + col;
            if (0 <= tr && tr < r && 0 <= tc && tc < c && map[tr, tc] != 'X' && map[tr, tc] != 'D' && !waterV[tr, tc])
            {
                waterV[tr, tc] = true;
                water.Enqueue((tr, tc));
            }
        }
    }

    int hcnt = hedgehog.Count;
    while (hcnt-- > 0)
    {
        var (hr, hc) = hedgehog.Dequeue();
        if (map[hr, hc] == 'D')
        {
            Console.WriteLine(cnt);
            return;
        }

        foreach (var (row, col) in dir)
        {
            int tr = hr + row;
            int tc = hc + col;
            if (0 <= tr && tr < r && 0 <= tc && tc < c && map[tr, tc] != 'X' && !waterV[tr, tc] && !hedgehogV[tr, tc])
            {
                hedgehogV[tr, tc] = true;
                hedgehog.Enqueue((tr, tc));
            }
        }
    }

    cnt++;
}

Console.WriteLine("KAKTUS");