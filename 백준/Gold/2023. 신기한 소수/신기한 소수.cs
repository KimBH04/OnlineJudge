using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(Console.ReadLine()!);
BackTracking(sw, 0, 0, n);

static void BackTracking(StreamWriter sw, int prime, int m, int depth)
{
    if (m == depth)
    {
        sw.WriteLine(prime);
    }
    else
    {
        prime *= 10;
        for (int i = 1; i < 10; i++)
        {
            prime += i;
            if (IsPrime(prime))
            {
                BackTracking(sw, prime, m + 1, depth);
            }
            prime -= i;
        }
    }
}

static bool IsPrime(int n)
{
    if (n == 1)
    {
        return false;
    }
    if (n == 2)
    {
        return true;
    }

    double sqrtn = Math.Sqrt(n);
    for (int i = 2; i <= sqrtn; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }

    return true;
}
