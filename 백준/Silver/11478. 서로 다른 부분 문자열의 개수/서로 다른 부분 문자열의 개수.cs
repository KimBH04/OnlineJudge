string s = Console.ReadLine()!;
int l = s.Length;

HashSet<string> h = new();
for (int i = 1; i <= l; i++)
{
    for (int j = 0; j < l - i + 1; j++)
    {
        if (!h.Contains(s[j..(j + i)]))
        {
            h.Add(s[j..(j + i)]);
        }
    }
}

Console.WriteLine(h.Count);