using System.Numerics;

var n = int.Parse(Console.ReadLine()!);
BigInteger f = 1;
for (int i = 2; i <= n; i++)
{
    f *= i;
}

var a = f.ToString().ToCharArray().Reverse().ToArray();
var r = 0;
foreach (var x in a)
{
    if (x != 48)
        break;

    r++;
}
Console.WriteLine(r);