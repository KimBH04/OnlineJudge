int n = int.Parse(Console.ReadLine()!);

int r = 0;
string s = Console.ReadLine()!;
for (int i = 0; i < n / 2; i++)
{
    if (s[i] != s[^(i + 1)])
    {
        r++;
    }
}

Console.WriteLine(r);