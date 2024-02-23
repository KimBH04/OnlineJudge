int n = int.Parse(Console.ReadLine()!);
int[,] map = new int[n, n];
int[,,] dp = new int[n, n, 3];
for (int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        map[i, j] = int.Parse(inputs[j]);
    }
}

dp[n - 1, n - 1, 0] = dp[n - 1, n - 1, 1] = dp[n - 1, n - 1, 2] = 1;
int r = CarryPipe(map, dp, 0, 1, n, 0);
Console.WriteLine(r);

static int CarryPipe(int[,] map, int[,,] dp, int r, int c, int n, int dir)
{
    int result = 0;
    if (dir == 0)
    {
        if (dp[r, c, 0] != 0)
        {
            return dp[r, c, 0];
        }

        if (c + 1 < n && map[r, c + 1] == 0)
        {
            result += CarryPipe(map, dp, r, c + 1, n, 0);
        }
        if (r + 1 < n && c + 1 < n && map[r + 1, c + 1] == 0 && map[r + 1, c] == 0 && map[r, c + 1] == 0)
        {
            result += CarryPipe(map, dp, r + 1, c + 1, n, 2);
        }
        dp[r, c, 0] = result;
    }
    else if (dir == 1)
    {
        if (dp[r, c, 1] != 0)
        {
            return dp[r, c, 1];
        }

        if (r + 1 < n && map[r + 1, c] == 0)
        {
            result += CarryPipe(map, dp, r + 1, c, n, 1);
        }
        if (r + 1 < n && c + 1 < n && map[r + 1, c + 1] == 0 && map[r + 1, c] == 0 && map[r, c + 1] == 0)
        {
            result += CarryPipe(map, dp, r + 1, c + 1, n, 2);
        }
        dp[r, c, 1] = result;
    }
    else
    {
        if (dp[r, c, 2] != 0)
        {
            return dp[r, c, 2];
        }

        if (c + 1 < n && map[r, c + 1] == 0)
        {
            result += CarryPipe(map, dp, r, c + 1, n, 0);
        }
        if (r + 1 < n && map[r + 1, c] == 0)
        {
            result += CarryPipe(map, dp, r + 1, c, n, 1);
        }
        if (r + 1 < n && c + 1 < n && map[r + 1, c + 1] == 0 && map[r + 1, c] == 0 && map[r, c + 1] == 0)
        {
            result += CarryPipe(map, dp, r + 1, c + 1, n, 2);
        }
        dp[r, c, 2] = result;
    }

    return result;
}