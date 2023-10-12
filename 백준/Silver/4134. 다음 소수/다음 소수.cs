static bool IsPrime(uint n)
{
    if (n == 1 || n == 0)
        return false;
    if (n == 2)
        return true;

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

int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    uint n = uint.Parse(Console.ReadLine()!);

here:;
    if (!IsPrime(n))
    {
        n++;
        goto here;
    }

    Console.WriteLine(n);
}
