long t = long.Parse(Console.ReadLine()!);
for (long i = 1; i <= t; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    long p = long.Parse(inputs[0]), q = long.Parse(inputs[1]);
    long a = 0, b = 1;
    while (p-- > 1)
    {
        (a, b) = (b, (a + b) % q);
    }

    Console.WriteLine($"Case #{i}: {b % q}");
}