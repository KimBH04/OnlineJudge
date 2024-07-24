while (true)
{
    string[] s = Console.ReadLine()!.Split();
    int n = int.Parse(s[0]);
    if (n == 0) break;
    List<string> ls = new(n) { s[1] };
    for (int i = 2; i <= n; i++)
    {
        if (s[i] != s[i - 1])
        {
            ls.Add(s[i]);
        }
    }
    Console.WriteLine(string.Join(' ', ls) + " $");
}