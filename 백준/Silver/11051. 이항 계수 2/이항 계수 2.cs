const int M = 10007;
var pow = (int n, int p) =>
{
    n %= M;
    int result = 1;
    while (p > 0)
    {
        if ((p & 1) == 1)
        {
            result *= n;
            result %= M;
        }
        n *= n;
        n %= M;
        p >>= 1;
    }
    return result;
};

var inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), k = int.Parse(inputs[1]);

var f = new int[n + 1];
f[0] = 1;
for (int i = 1; i <= n; i++)
{
    f[i] = f[i - 1] * i % M;
}

Console.WriteLine(f[n] * pow(f[k] * f[n - k] % M, M - 2) % M);