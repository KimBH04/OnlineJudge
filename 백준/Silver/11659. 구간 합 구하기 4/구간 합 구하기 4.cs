using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());

var I = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
var s = sr.ReadLine().Split();
var a = new int[I[0] + 1];

a[0] = 0;
for (int i = 1; i < I[0] + 1; i++) a[i] = a[i - 1] + int.Parse(s[i - 1]);

for (int i = 0; i < I[1]; i++)
{
    var p = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    sw.WriteLine(a[p[1]] - a[p[0] - 1]);
}