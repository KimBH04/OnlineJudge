int n = int.Parse(Console.ReadLine()!);
string[] s = new string[n];
Dictionary<string, bool> dic = new();
int nullIdx = -1;

for (int i = 0; i < n; i++)
{
    string w = Console.ReadLine()!;
    if (w == "?")
    {
        nullIdx = i;
    }
    else
    {
        s[i] = w;
        dic.Add(w, true);
    }
}

int m = int.Parse(Console.ReadLine()!);
while (m-- > 0)
{
    string w = Console.ReadLine()!;
    if (!dic.ContainsKey(w))
    {
        if ((nullIdx < n - 1 ? w[^1] == s[nullIdx + 1][0] : true) && (nullIdx > 0 ? w[0] == s[nullIdx - 1][^1] : true))
        {
            Console.WriteLine(w);
            break;
        }
    }
}
