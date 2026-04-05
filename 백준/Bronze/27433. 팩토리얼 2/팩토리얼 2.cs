static long Factorial(int n)
{
    if (n < 2) return 1;

    return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));