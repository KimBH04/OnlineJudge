using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

while (true)
{
    int x = int.Parse(sr.ReadLine()!);
    if (x == 0)
        break;

    int r = 0;
    for (int i = 1; x > 0; x /= 10, i++)
    {
        r += x % 10 * Factorial(i);
    }
    sw.WriteLine(r);
}

static int Factorial(int n)
{
    int r = 1;
    for (int i = 2; i <= n; i++)
    {
        r *= i;
    }
    return r;
}
