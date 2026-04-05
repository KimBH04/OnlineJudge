var n = int.Parse(Console.ReadLine()!);
var max = 0;

var rope = new int[n];
for (int i = 0; i < n; i++)
{
    rope[i] = int.Parse(Console.ReadLine()!);
}

Array.Sort(rope);

for (int i = 0; i < n; i++)
{
    max = Math.Max(max, rope[i] * (n - i));
}

Console.WriteLine(max);