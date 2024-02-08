const int MOD = 1_000_000_009;

int[] dp = new int[1000001];
dp[0] = 0;
dp[1] = 1;
dp[2] = 2;
dp[3] = 4;
for (int i = 4; i < 1000001; i++)
{
    dp[i] = ((dp[i - 1] % MOD + dp[i - 2] % MOD) % MOD + dp[i - 3] % MOD) % MOD;
}

int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine(dp[n]);
}
