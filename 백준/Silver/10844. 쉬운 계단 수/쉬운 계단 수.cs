int n = int.Parse(Console.ReadLine()!);

const int MOD = 1_000_000_000;
int[] num = { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
for (int i = 1; i < n; i++)
{
    int[] temp =
    {
        num[1],
        (num[0] % MOD + num[2] % MOD) % MOD,
        (num[1] % MOD + num[3] % MOD) % MOD,
        (num[2] % MOD + num[4] % MOD) % MOD,
        (num[3] % MOD + num[5] % MOD) % MOD,
        (num[4] % MOD + num[6] % MOD) % MOD,
        (num[5] % MOD + num[7] % MOD) % MOD,
        (num[6] % MOD + num[8] % MOD) % MOD,
        (num[7] % MOD + num[9] % MOD) % MOD,
        num[8],
    };

    for (int j = 0; j < 10; j++)
    {
        num[j] = temp[j];
    }
}

int r = 0;
for (int i = 0; i < 10; i++)
{
    r = (r % MOD + num[i] % MOD) % MOD;
}

Console.WriteLine(r);