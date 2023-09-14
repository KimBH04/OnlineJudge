int t = int.Parse(Console.ReadLine()!);
for (int x = 1; x <= t; x++)
{
    int y = int.Parse(Console.ReadLine()!);
    if (y > 4500)
    {
        Console.WriteLine($"Case #{x}: Round 1");
    }
    else if (y > 1000)
    {
        Console.WriteLine($"Case #{x}: Round 2");
    }
    else if (y > 25)
    {
        Console.WriteLine($"Case #{x}: Round 3");
    }
    else
    {
        Console.WriteLine($"Case #{x}: World Finals");
    }
}
