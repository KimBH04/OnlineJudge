using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(Console.ReadLine()!);
sw.WriteLine(((System.Numerics.BigInteger)1 << n) - 1);

if (n < 21)
    Hanoi(sw, n, 1, 2, 3);

static void Hanoi(StreamWriter sw, int n, int start, int mid, int end)
{
    if (n == 1)
    {
        Print(sw, start, end);
    }
    else
    {
        Hanoi(sw, n - 1, start, end, mid);
        Print(sw, start, end);
        Hanoi(sw, n - 1, mid, start, end);
    }
}

static void Print(StreamWriter sw, int start, int end)
{
    sw.WriteLine($"{start} {end}");
}
