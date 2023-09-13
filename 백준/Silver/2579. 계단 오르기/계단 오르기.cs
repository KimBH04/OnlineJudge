int n = int.Parse(Console.ReadLine()!);
int[] stairs = new int[n];
int[] dp = new int[n];
for (int i = 0; i < n; i++)
{
    stairs[i] = int.Parse(Console.ReadLine()!);
}

if (n == 1)
{
    Console.WriteLine(stairs[0]);
    return;
}
else if (n == 2)
{
    Console.WriteLine(stairs[0] + stairs[1]);
    return;
}

dp[0] = stairs[0];
dp[1] = stairs[0] + stairs[1];
dp[2] = (stairs[0] > stairs[1] ? stairs[0] : stairs[1]) + stairs[2];

for (int i = 3; i < n; i++)
{
    dp[i] = (dp[i - 2] > dp[i - 3] + stairs[i - 1] ? dp[i - 2] : dp[i - 3] + stairs[i - 1]) + stairs[i];
}

Console.WriteLine(dp[n - 1]);