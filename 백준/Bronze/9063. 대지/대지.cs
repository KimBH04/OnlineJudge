using static System.Math;

var n = int.Parse(Console.ReadLine()!);

Tama max = new(int.MinValue), min = new(int.MaxValue);

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine()!.Split();
    int x = int.Parse(input[0]), y = int.Parse(input[1]);

    max.x = Max(max.x, x);
    max.y = Max(max.y, y);

    min.x = Min(min.x, x);
    min.y = Min(min.y, y);
}

int difx = max.x - min.x, dify = max.y - min.y;

Console.WriteLine(difx * dify);

struct Tama
{
    public int x, y;

    public Tama(int m)
    {
        x = y = m;
    }
}