using System.Numerics;

using StreamWriter sw = new(Console.OpenStandardOutput());
sw.WriteLine(Factorial(1, long.Parse(Console.ReadLine()!)));

static BigInteger Factorial(long start, long n)
{
    long i;
    if (n <= 16)
    {
        BigInteger r = new(start);
        for (i = start + 1; i < start + n; i++)
        {
            r *= i;
        }
        return r;
    }

    i = n / 2;
    return Factorial(start, i) * Factorial(start + i, n - i);
}