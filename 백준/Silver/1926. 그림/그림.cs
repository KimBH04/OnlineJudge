string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]);

bool[,] map = new bool[n, m];
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine()!.Split();
    for (int j = 0; j < m; j++)
    {
        map[i, j] = input[j] == "1";
    }
}

int[,] dir = { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
int r = 0;
int max = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (map[i, j])
        {
            r++;
            max = Math.Max(max, BFS(map, dir, j, i, n, m));
        }
    }
}

Console.WriteLine($"{r}\n{max}");

static int BFS(bool[,] map, int[,] dir, int x, int y, int n, int m)
{
    int r = 1;
    map[y, x] = false;

    for (int i = 0; i < 4; i++)
    {
        if (x + dir[i, 0] < m && x + dir[i, 0] >= 0 && y + dir[i, 1] < n && y + dir[i, 1] >= 0)
        {
            if (map[y + dir[i, 1], x + dir[i, 0]])
            {
                r += BFS(map, dir, x + dir[i, 0], y + dir[i, 1], n, m);
            }
        }
    }

    return r;
}
