var input = Console.ReadLine()!.Split();

var n = input[0];
var b = int.Parse(input[1]);
var num = (char c) =>
{
    if (c - 48 < 10)
    {
        return c - 48;
    }
    else
    {
        return c - 55;
    }
};

var r = 0;
var m = 1;
while (n.Length > 0)
{
    r += num(n[^1]) * m;

    n = n[..^1];
    m *= b;
}

Console.WriteLine(r);