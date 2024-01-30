const int MOD = 10_007;

int[] counts = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

int n = int.Parse(Console.ReadLine()!);
while (n-- > 0)
{
    for (int i = 9; i > 0; i--)
    {
        counts[i - 1] = (counts[i - 1] % MOD + counts[i] % MOD) % MOD;
    }
}

Console.WriteLine(counts[0]);