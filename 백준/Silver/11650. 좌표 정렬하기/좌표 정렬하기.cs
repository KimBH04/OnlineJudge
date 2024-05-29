using var sw = new StreamWriter(Console.OpenStandardOutput());

var n = int.Parse(Console.ReadLine());
var C = new (int x, int y)[n];

for (int i = 0; i < n; i++)
{
    var c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    C[i] = (c[0], c[1]);
}

Array.Sort(C);

foreach (var c in C) sw.WriteLine(c.x + " " + c.y);