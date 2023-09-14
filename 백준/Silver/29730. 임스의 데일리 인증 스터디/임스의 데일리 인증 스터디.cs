int n = int.Parse(Console.ReadLine()!);
List<string> l1 = new(), l2 = new();
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine()!;
    if (s.Length > 7)
    {
        if (s[..7] == "boj.kr/")
        {
            l2.Add(s);
            continue;
        }
    }
    l1.Add(s);
}

WriteLine(l1.OrderBy(x => x).OrderBy(x => x.Length));
WriteLine(l2.OrderBy(x => int.Parse(x[7..])));

static void WriteLine<T>(IEnumerable<T> e)
{
    foreach (T t in e)
    {
        Console.WriteLine(t);
    }
}