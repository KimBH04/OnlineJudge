int n = int.Parse(Console.ReadLine()!);
string[] s = new string[n];

for (int i = 0; i < n; i++)
{
    s[i] = Console.ReadLine()!;
}

s = s.OrderBy(x => x.Length).ToArray();

int sl = s[0].Length;
int m = 0;
for (int i = 0; i < sl; i++)
{
    for (int j = i + 1; j <= sl; j++)
    {
        int c = 0;
        if (ContainsCheck(s, i, j, ref c))
        {
            if (m < c)
            {
                m = c;
            }
        }
    }
}

Console.WriteLine(m);

static bool ContainsCheck(string[] s, int start, int end, ref int count)
{
    foreach (string str in s)
    {
        if (!str.Contains(s[0][start..end]))
        {
            return false;
        }
    }
    count = end - start;
    return true;
}
