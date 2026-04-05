int n = int.Parse(Console.ReadLine()!);
while (n-- > 0)
{
    string s = Console.ReadLine()!;
    if (s.Contains('S'))
    {
        Console.WriteLine(s);
        return;
    }
}
