var n = int.Parse(Console.ReadLine()!);
var s = new int[n];

for (int i = 0; i < n; i++)
{
    s[i] = int.Parse(Console.ReadLine()!);
}

int p = s[1] - s[0], m = s[1] / s[0];
Console.WriteLine(s[1] + p == s[2] ? s[^1] + p : s[^1] * m);