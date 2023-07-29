string s = Console.ReadLine()!;
int l = s[^1] == '0' ? 2 : s.Length / 2;
int a = int.Parse(s[..^l]), b = int.Parse(s[^l..]);
Console.WriteLine(a + b);