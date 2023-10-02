int n = int.Parse(Console.ReadLine()!);
int[] t = new int[n], b = new int[n - 1];
for (int i = 0; i < n; i++)
{
    t[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < n - 1; i++)
{
    b[i] = t[i + 1] - t[i];
}

int gcd = b[0];
foreach (int i in b[1..])
{
    gcd = GCD(gcd, i);
}

int r = 0;
foreach (int i in b)
{
    r += i / gcd - 1;
}

Console.WriteLine(r);

static int GCD(int a, int b)
{
    if (a < b)
    {
        (a, b) = (b, a);
    }

    while (b > 0)
    {
        (a, b) = (b, a % b);
    }

    return a;
}
