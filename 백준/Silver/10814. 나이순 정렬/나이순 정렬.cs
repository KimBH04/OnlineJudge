using var sw = new StreamWriter(Console.OpenStandardOutput());

var n = int.Parse(Console.ReadLine());
var M = new (int a, string n)[n];

for (int i = 0; i < n; i++)
{
    var I = Console.ReadLine().Split();
    M[i] = (int.Parse(I[0]), I[1]);
}

M = M.OrderBy(x => x.a).ToArray();

foreach (var m in M) sw.WriteLine(m.a + " " + m.n);