int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    string x = Console.ReadLine()!;
    bool[] n = { true, true, true, true, true, true, true, true, true, true };
    int r = 0;
    foreach (char c in x)
    {
        if (n[c - 48])
        {
            n[c - 48] = false;
            r++;
        }
    }

    Console.WriteLine(r);
}
