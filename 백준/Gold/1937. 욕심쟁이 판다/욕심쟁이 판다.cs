int n = int.Parse(Console.ReadLine()!);
int[,] map = new int[n, n], memo = new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        map[i, j] = int.Parse(input[j]);
        memo[i, j] = 0;
    }
}

int[] dx = { 0, 0, -1, 1 }, dy = { 1, -1, 0, 0 };
int r = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        r = Math.Max(r, Depth(i, j));
    }
}

Console.WriteLine(r);

int Depth(int x, int y)
{
    if (memo[x, y] > 0)
        return memo[x, y];

    int r = 1;

    for (int i = 0; i < 4; i++)
    {
        if (x + dx[i] >= 0 && x + dx[i] < n && y + dy[i] >= 0 && y + dy[i] < n)
        {
            if (map[x + dx[i], y + dy[i]] > map[x, y])
            {
                r = Math.Max(r, Depth(x + dx[i], y + dy[i]) + 1);
            }
        }
    }

    memo[x, y] = r;
    return r;
}
