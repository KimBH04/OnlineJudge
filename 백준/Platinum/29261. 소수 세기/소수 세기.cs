const int P = 3000000;

bool[] eratos = new bool[P];
int[] memo = new int[P];

for (int i = 2; i < P; i++)
{
    eratos[i] = true;
    memo[i] = 0;
}

for (int i = 2; i < P; i++)
{
    if (eratos[i])
    {
        for (int j = i + i; j < P; j += i)
        {
            eratos[j] = false;
        }
    }
}

memo[2] = memo[3] = 1;

int p = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrimeCount(p));

int PrimeCount(int p)
{
    if (memo[p] != 0)
    {
        return memo[p];
    }

    int a, b;
    a = b = p / 2;
    while (!eratos[a] || !eratos[b])
    {
        a++;
        b--;
    }

    return memo[p] = PrimeCount(a) + PrimeCount(b) + 1;
}
