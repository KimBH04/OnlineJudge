int n = int.Parse(Console.ReadLine()!);
if (n == 0)
{
    Console.WriteLine(0);
    return;
}

double[] i = new double[n];

int t = (int)Math.Round(n * 3 / 20d, MidpointRounding.AwayFromZero);

while (n-- > 0)
{
    i[n] = int.Parse(Console.ReadLine()!);
}

Array.Sort(i);
i = i[t..^t];
Console.WriteLine(Math.Round(i.Sum() / i.Length, MidpointRounding.AwayFromZero));