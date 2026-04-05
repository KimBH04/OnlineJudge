static int W(int[,,] dp, int a, int b, int c)
{
    if (a <= 0 || b <= 0 || c <= 0)
    {
        return dp[0, 0, 0] = 1;
    }
    
    if (a > 20 || b > 20 || c > 20)
    {
        return dp[20, 20, 20] = W(dp, 20, 20, 20);
    }

    if (dp[a, b, c] > -1)
    {
        return dp[a, b, c];
    }

    if (a < b && b < c)
    {
        return
            (dp[a, b, c - 1] = W(dp, a, b, c - 1)) +
            (dp[a, b - 1, c - 1] = W(dp, a, b - 1, c - 1)) -
            (dp[a, b - 1, c] = W(dp, a, b - 1, c));
    }

    return
        (dp[a - 1, b, c] = W(dp, a - 1, b, c)) +
        (dp[a - 1, b - 1, c] = W(dp, a - 1, b - 1, c)) +
        (dp[a - 1, b, c - 1] = W(dp, a - 1, b, c - 1)) -
        (dp[a - 1, b - 1, c - 1] = W(dp, a - 1, b - 1, c - 1));
}

int[,,] dp = new int[32, 32, 32];

for (int i = 0; i < 32; i++)
{
    for (int j = 0; j < 32; j++)
    {
        for (int k = 0; k < 32; k++)
        {
            dp[i, j, k] = -1;
        }
    }
}

while (true)
{
    string[] inputs = Console.ReadLine()!.Split();
    int a = int.Parse(inputs[0]),
        b = int.Parse(inputs[1]),
        c = int.Parse(inputs[2]);

    if (a == b && b == c && c == -1)
    {
        break;
    }

    Console.WriteLine($"w({a}, {b}, {c}) = {W(dp, a, b, c)}");
}
