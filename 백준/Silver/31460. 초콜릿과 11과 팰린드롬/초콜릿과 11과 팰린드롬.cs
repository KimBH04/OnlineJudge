int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    if (n % 2 == 0)
    {
        Console.WriteLine(new string('1', n));
    }
    else
    {
        Console.WriteLine(new string('1', (n - 1) / 2) + ((n - 1) / 2 % 2 == 0 ? 0 : 2) + new string('1', (n - 1) / 2));
    }
}
