HashSet<string> color = new();
for (int i = 0; i < 2; i++)
{
    string[] s = Console.ReadLine()!.Split();
    for (int j = 0; j < 2; j++)
        if (!color.Contains(s[j]))
            color.Add(s[j]);
}

List<string> list = new();
foreach (string s in color)
{
    foreach (string s2 in color)
    {
        list.Add($"{s} {s2}");
    }
}

list.Sort();
Console.WriteLine(string.Join("\n", list));