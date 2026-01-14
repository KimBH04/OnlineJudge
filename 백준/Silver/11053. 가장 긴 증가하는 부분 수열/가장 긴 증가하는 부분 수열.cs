var n = int.Parse(Console.ReadLine()!);
var a = Array.ConvertAll(("0 " + Console.ReadLine()!).Split(), int.Parse);

var d = new int[n + 1];
d[0] = 0;

for (int i = 0; i <= n; i++)
{
    var max = 0;
    for (int j = 0; j < i; j++)
    {
        if (a[j] < a[i] && max <= d[j])
        {
            max = d[j];
            d[i] = max + 1;
        }
    }
}

Console.WriteLine(d.Max());