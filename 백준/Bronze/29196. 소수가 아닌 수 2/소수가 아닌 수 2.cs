int k = (int)(double.Parse(Console.ReadLine()!) * 100000000);
int n = 100000000;
int gcd = GCD(k, n);

Console.WriteLine($"YES\n{k / gcd} {n / gcd}");

static int GCD(int a, int b)
{
    if (a < b)
        (a, b) = (b, a);

    while (b > 0)
    {
        (a, b) = (b, a % b);
    }

    return a;
}
