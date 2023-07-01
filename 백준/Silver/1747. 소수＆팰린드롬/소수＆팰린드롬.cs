bool IsPrime(int n)
{
    if (n == 1)
        return false;

    double sqrtn = Math.Sqrt(n);
    for (int i = 2; i <= sqrtn; i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}

bool IsPalindrome(string n)
{
    int l = n.Length;
    for (int i = 0; i < l / 2; i++)
    {
        if (n[i] != n[^(i + 1)])
            return false;
    }
    return true;
}

int n = int.Parse(Console.ReadLine()!);
for (; ; n++)
{
    if (IsPrime(n))
    {
        if (IsPalindrome(n + ""))
        {
            Console.WriteLine(n);
            break;
        }
    }
}
