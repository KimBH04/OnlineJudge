var rev = (string s) => string.Join("", s.Reverse());
var tail = (string s) => s[1..];

int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    string s = Console.ReadLine()!;
    int n = (int)Math.Ceiling(s.Length / 3d);

    string _s = s[..n];

    Console.WriteLine(
        _s + rev(_s) + _s == s ||
        _s + tail(rev(_s)) + _s == s ||
        _s + rev(_s) + tail(_s) == s ||
        _s + tail(rev(_s)) + tail(_s) == s ? 1 : 0);
}
