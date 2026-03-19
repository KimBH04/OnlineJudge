using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

string[] inputs = sr.ReadLine()!.Split();
int n = int.Parse(inputs[0]), t = int.Parse(inputs[1]);
var a = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

sw.WriteLine(string.Join(' ', a[..t].OrderBy(x => x).Concat(a[t..])));