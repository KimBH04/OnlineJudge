var n = int.Parse(Console.ReadLine()!);
var a = new int[n][];
var d = new int?[n][];

for (int i = 0; i < n; i++)
{
    d[i] = new int?[3];
    a[i] = new int[3];
    var input = Console.ReadLine()!.Split();
    int r = int.Parse(input[0]), b = int.Parse(input[1]), g = int.Parse(input[2]);
    a[i][0] = r;
    a[i][1] = b;
    a[i][2] = g;
}

d[0][0] = a[0][0];
d[0][1] = a[0][1];
d[0][2] = a[0][2];

for (var i = 1; i < n; i++)
{
    //0
    if (d[i][1] == null)
    {
        d[i][1] = d[i - 1][0] + a[i][1];
    }
    else
    {
        d[i][1] = Math.Min((int)d[i][1]!, (int)d[i - 1][0]! + a[i][1]);
    }

    if (d[i][2] == null)
    {
        d[i][2] = d[i - 1][0] + a[i][2];
    }
    else
    {
        d[i][2] = Math.Min((int)d[i][2]!, (int)d[i - 1][0]! + a[i][2]);
    }

    //1
    if (d[i][0] == null)
    {
        d[i][0] = d[i - 1][1] + a[i][0];
    }
    else
    {
        d[i][0] = Math.Min((int)d[i][0]!, (int)d[i - 1][1]! + a[i][0]);
    }

    if (d[i][2] == null)
    {
        d[i][2] = d[i - 1][1] + a[i][2];
    }
    else
    {
        d[i][2] = Math.Min((int)d[i][2]!, (int)d[i - 1][1]! + a[i][2]);
    }

    //2
    if (d[i][0] == null)
    {
        d[i][0] = d[i - 1][2] + a[i][0];
    }
    else
    {
        d[i][0] = Math.Min((int)d[i][0]!, (int)d[i - 1][2]! + a[i][0]);
    }

    if (d[i][1] == null)
    {
        d[i][1] = d[i - 1][2] + a[i][1];
    }
    else
    {
        d[i][1] = Math.Min((int)d[i][1]!, (int)d[i - 1][2]! + a[i][1]);
    }
}

Console.WriteLine(d[^1].Min());