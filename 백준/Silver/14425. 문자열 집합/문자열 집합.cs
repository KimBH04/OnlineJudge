using var sr = new StreamReader(Console.OpenStandardInput());

var input = sr.ReadLine().Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]);
var s = new Dictionary<string, bool>();

var r = 0;

for (int i = 0; i < n; i++)
{
    s.Add(sr.ReadLine(), false);
}

for (int i = 0; i < m; i++)
{
    if (s.ContainsKey(sr.ReadLine()))
    {
        r++;
    }
}

Console.WriteLine(r);