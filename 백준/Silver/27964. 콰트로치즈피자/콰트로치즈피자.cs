int n = int.Parse(Console.ReadLine()!);
string[] toping = Console.ReadLine()!.Split();

Dictionary<string, bool> dic = new();
foreach (string s in toping)
{
    if (s.Length > 5)
    {
        if (s[^6..] == "Cheese" && !dic.ContainsKey(s))
        {
            dic.Add(s, true);
        }
    }
}

Console.WriteLine(dic.Count > 3 ? "yummy" : "sad");