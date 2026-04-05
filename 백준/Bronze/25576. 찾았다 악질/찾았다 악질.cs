using var sr = new StreamReader(Console.OpenStandardInput());

var input = sr.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]);

var r = 0;

var ralpa = sr.ReadLine()!.Split();
for (int i = 1; i < n; i++)
{
    input = sr.ReadLine()!.Split();
    var sum = 0;

    for (int j = 0; j < m; j++)
    {
        sum += Math.Abs(int.Parse(ralpa[j]) - int.Parse(input[j]));
    }

    r += sum > 2000 ? 1 : -1;
}

Console.WriteLine(r >= 0 ? "YES" : "NO");