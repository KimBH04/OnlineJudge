var input = Console.ReadLine()!.Split();
long min = long.Parse(input[0]), max = long.Parse(input[1]);

var r = max - min + 1;
var powNN = new bool[r];
for (var i = 0; i <= max - min; i++)
{
    powNN[i] = true;
}

var m = Math.Sqrt(max);
for (long i = 2; i <= m; i++)
{
    var I = Math.Sqrt(i);
    for (long j = 2; j <= I; j++)
    {
        if (i % j == 0)
            goto here;
    }

    var ii = i * i;
    var jj = min / ii + (min % ii > 0 ? 1 : 0);
    while (ii * jj <= max)
    {
        if (powNN[ii * jj - min])
        {
            powNN[ii * jj - min] = false;
            r--;
        }
        jj++;
    }
here:;
}

Console.WriteLine(r);