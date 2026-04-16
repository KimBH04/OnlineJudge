using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());

var dic = new Dictionary<int, int>();

var n = int.Parse(sr.ReadLine());
var x = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

var t = x.Distinct().ToArray();
Array.Sort(t);

for (int i = 0; i < t.Length; i++)
{
    dic.Add(t[i], i);
}

foreach (var i in x) sw.Write(dic[i] + " ");