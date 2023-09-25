int n = int.Parse(Console.ReadLine()!);
int[][] triangle = new int[n][], dp = new int[n][];
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()!.Split();
    triangle[i] = new int[i + 1];
    dp[i] = new int[i + 1];
    for (int j = 0; j < i + 1; j++)
    {
        triangle[i][j] = int.Parse(input[j]);
        dp[i][j] = -1;
    }
}

Console.WriteLine(IntegerTriangle(triangle, dp, 0, 0, n));

static int IntegerTriangle(int[][] triangle, int[][] dp, int floor, int vertical, int n)
{
    if (floor == n - 1)
    {
        return dp[floor][vertical] = triangle[floor][vertical];
    }

    if (dp[floor][vertical] != -1)
    {
        return dp[floor][vertical];
    }

    return dp[floor][vertical] = triangle[floor][vertical] += Math.Max(
        IntegerTriangle(triangle, dp, floor + 1, vertical, n),
        IntegerTriangle(triangle, dp, floor + 1, vertical + 1, n));
}
