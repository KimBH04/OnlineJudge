var N = double.Parse(Console.ReadLine());
var iN = (int)N;

var san = 0d;
var jung = new int[iN];
var choi = Enumerable.Repeat(0, 8001).ToArray();

for (int i = 0; i < N; i++)
{
    var n = int.Parse(Console.ReadLine());
    san += n;
    jung[i] = n;
    choi[n + 4000]++;
}

Array.Sort(jung);

Console.WriteLine(Math.Round(san / N, 0) + 0);
Console.WriteLine(jung[iN / 2]);

var max = 0;
var maximum = new List<int>();
foreach (var i in choi) max = Math.Max(max, i);
for (int i = 0; i < 8001; i++) if (choi[i] == max) maximum.Add(i - 4000);
Console.WriteLine(maximum[maximum.Count == 1 ? 0 : 1]);

Console.WriteLine(jung[^1] - jung[0]);