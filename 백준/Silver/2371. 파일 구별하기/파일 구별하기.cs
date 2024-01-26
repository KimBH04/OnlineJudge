int n = int.Parse(Console.ReadLine()!);
string[][] files = new string[n][];

for (int i = 0; i < n; i++)
{
    files[i] = Console.ReadLine()!.Split();
}

for (int k = 1; ; k++)
{
    HashSet<string> hash = new();
    for (int i = 0; i < n; i++)
    {
        if (files[i].Length < k)
        {
            hash.Add(string.Join(' ', files[i]));
        }
        else
        {
            hash.Add(string.Join(' ', files[i][..k]));
        }
    }

    if (hash.Count == n)
    {
        Console.WriteLine(k);
        break;
    }
}
