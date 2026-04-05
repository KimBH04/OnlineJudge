while (true)
{
    var n = int.Parse(Console.ReadLine()!);
    if (n < 3) break;

    var primes = new List<int>();
    var nSqrt = Math.Sqrt(n);
    for (int i = 2; i <= nSqrt; i++)
    {
        if (n % i == 0) primes.Add(i);
    }

    foreach (var i in primes.ToArray())
    {
        primes.Add(n / i);
    }
    primes.Sort();

    Console.WriteLine(n + (1 + primes.Sum() == n ? $" = 1 + {string.Join(" + ", primes.ToArray())}" : " is NOT perfect."));
}