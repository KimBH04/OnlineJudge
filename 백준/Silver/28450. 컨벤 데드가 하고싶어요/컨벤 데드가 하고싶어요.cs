string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]);

long[,] map = new long[n, m], dp = new long[n, m];
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine()!.Split();
    for (int j = 0; j < m; j++)
    {
        map[i, j] = int.Parse(input[j]);
        dp[i, j] = -1;
    }
}

int h = int.Parse(Console.ReadLine()!);
long r = Function(map, dp, 0, 0, n, m);

Console.WriteLine(r > h ? "NO" : "YES\n" + r);

static long Function(long[,] map, long[,] dp, int x, int y, int n, int m)
{
    if (y >= n || x >= m)
    {
        return -1;
    }

    if (dp[y, x] != -1)
    {
        return dp[y, x];
    }

    long right = Function(map, dp, x + 1, y, n, m);
    long down = Function(map, dp, x, y + 1, n, m);

    if (right < 0 && down < 0)
    {
        return dp[y, x] = map[y, x];
    }

    if (right < 0)
    {
        return dp[y, x] = map[y, x] + down;
    }
    else if (down < 0)
    {
        return dp[y, x] = map[y, x] + right;
    }
    else
    {
        return dp[y, x] = map[y, x] + Math.Min(right, down);
    }
}
