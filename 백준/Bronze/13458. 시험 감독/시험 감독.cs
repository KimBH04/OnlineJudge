var n = int.Parse(Console.ReadLine()!);
var x = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
var input = Console.ReadLine()!.Split();
int a = int.Parse(input[0]), b = int.Parse(input[1]);

var r = 0L;
foreach (var item in x)
{
    var temp = item;
    temp -= a;
    r++;

    if (temp > 0)
    {
        r += temp / b + (temp % b > 0 ? 1 : 0);
    }
}

Console.WriteLine(r);