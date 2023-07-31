int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    int r = 0;
    bool[] askii = new bool[26] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
    string s = Console.ReadLine()!;
    foreach (char c in s)
    {
        askii[c - 65] = false;
    }
    for (int i = 0; i < 26; i++)
    {
        if (askii[i])
        {
            r += i + 65;
        }
    }
    Console.WriteLine(r);
}
