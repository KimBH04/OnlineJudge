var n = int.Parse(Console.ReadLine());
var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
var d = a.Distinct().ToDictionary(x => x);
var A = a.ToArray();
Array.Sort(A);

var r = 1;
for (int i = 0; i < n; i++)
{
    if (i - 1 >= 0)
    {
        if (A[i] == A[i - 1])
        {
            d[A[i]] = r;
        }
        else
        {
            r = i + 1;
            d[A[i]] = r;
        }
    }
    else
    {
        d[A[0]] = 1;
    }
}

foreach (var x in a)
{
    Console.WriteLine(d[x]);
}