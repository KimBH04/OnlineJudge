for (int x = int.Parse(Console.ReadLine()!) + 1; x < 10000; x++)
{
    int y = x % 100 + x / 100;
    if (y * y == x)
    {
        Console.WriteLine(x);
        return;
    }
}

Console.WriteLine(-1);